using AutoMapper;
using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.TransactionServices.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MaternityCare_Backend.Service.TransactionServices
{
	internal sealed class TransactionService : ITransactionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly Utils utils;
		private readonly IConfiguration configuration;

		public TransactionService(IRepositoryManager repositoryManager, IMapper mapper, Utils utils, IConfiguration configuration)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.utils = utils;
			this.configuration = configuration;
		}

		public async Task<string> DisplayResultAsync(IQueryCollection query, CancellationToken ct = default)
		{
			var vnpay = new VnPayLibrary();
			foreach (var key in query.Keys)
			{
				if (key.StartsWith("vnp_"))
				{
					vnpay.AddResponseData(key, query[key]);
				}
			}

			var vnpSecureHash = query["vnp_SecureHash"];
			var isValid = vnpay.ValidateSignature(vnpSecureHash, configuration.GetSection("VNPay").GetSection("HashSecret").Value);

			if (!isValid)
			{
				return "Invalid signature";
			}

			var responseCode = vnpay.GetResponseData("vnp_ResponseCode");
			var transactionId = Guid.Parse(vnpay.GetResponseData("vnp_TxnRef"));
			var transaction = await repositoryManager.TransactionRepository.GetTransaction(transactionId, false, ct);

			if (transaction == null)
			{
				return "Không tìm thấy thông tin thanh toán";
			}

			// Update transaction status based on response code
			if (responseCode == "00")
			{
				return "Thanh toán thành công";
			}
			else
			{
				return "Thanh toán thất bại";
			}
		}

		public async Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, CancellationToken ct = default)
		{
			var transactionsWithMetaData = await repositoryManager.TransactionRepository.GetTransactions(transactionParameters, false, ct);
			var transactions = mapper.Map<IEnumerable<TransactionForReturnDto>>(transactionsWithMetaData);
			return (transactions, transactionsWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, CancellationToken ct = default)
		{
			var transactionsWithMetaData = await repositoryManager.TransactionRepository.GetTransactionsByUserId(userId, transactionParameters, false, ct);
			var transactions = mapper.Map<IEnumerable<TransactionForReturnDto>>(transactionsWithMetaData);
			return (transactions, transactionsWithMetaData.MetaData);
		}

		public async Task<IActionResult> IPNAsync(IQueryCollection query, CancellationToken ct = default)
		{
			var vnpay = new VnPayLibrary();
			foreach (var key in query.Keys)
			{
				if (key.StartsWith("vnp_"))
				{
					vnpay.AddResponseData(key, query[key]);
				}
			}

			var vnpSecureHash = query["vnp_SecureHash"];
			var isValid = vnpay.ValidateSignature(vnpSecureHash, configuration.GetSection("VNPay").GetSection("HashSecret").Value);

			if (!isValid)
			{
				return new JsonResult(new { RspCode = "97", Message = "Invalid signature" });
			}

			// Validate and update transaction status
			var transactionId = Guid.Parse(vnpay.GetResponseData("vnp_TxnRef"));
			var amount = long.Parse(vnpay.GetResponseData("vnp_Amount")) / 100;
			var responseCode = vnpay.GetResponseData("vnp_ResponseCode");
			var transaction = await repositoryManager.TransactionRepository.GetTransaction(transactionId, true, ct);
			var subscription = await repositoryManager.SubscriptionRepository.GetSubscription(transaction.SubscriptionId, true, ct);
			var package = await repositoryManager.PackageRepository.GetPackageById(subscription.PackageId, false, ct);

			if (transaction == null)
			{
				return new JsonResult(new { RspCode = "01", Message = "Order not found" });
			}

			// Update transaction status based on response code
			if (responseCode == "00")
			{
				subscription.StartDate = DateOnly.FromDateTime(DateTime.Now);
				subscription.EndDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(Convert.ToInt32(package.Duration)));
				transaction.Status = TransactionStatus.Success;
			}
			else
			{
				transaction.Status = TransactionStatus.Failed;
			}
			await repositoryManager.SaveAsync(ct);

			return new JsonResult(new { RspCode = "00", Message = "Confirm Success" });
		}
	}
}
