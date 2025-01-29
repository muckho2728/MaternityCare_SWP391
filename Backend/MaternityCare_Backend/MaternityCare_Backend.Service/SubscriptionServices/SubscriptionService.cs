using AutoMapper;
using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;
using MaternityCare_Backend.Service.TransactionServices;
using Microsoft.Extensions.Configuration;

namespace MaternityCare_Backend.Service.SubscriptionServices
{
	internal sealed class SubscriptionService : ISubscriptionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IConfiguration configuration;
		private readonly Utils utils;

		public SubscriptionService(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, Utils utils)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.configuration = configuration;
			this.utils = utils;
		}
		private async Task<Subscription?> CheckSubscriptionExist(Guid subscriptionId, bool trackChange)
		{
			var subscriptionEntity = await repositoryManager.SubscriptionRepository.GetSubscription(subscriptionId, trackChange);
			if (subscriptionEntity == null) throw new SubscriptionNotFoundException();
			return subscriptionEntity;
		}
		public async Task<string> CreateSubscription(SubscriptionForCreationDto subscriptionForCreationDto)
		{
			var subscriptionEntity = mapper.Map<Subscription>(subscriptionForCreationDto);
			subscriptionEntity.Id = Guid.NewGuid();
			repositoryManager.SubscriptionRepository.CreateSubscription(subscriptionEntity);

			var package = await repositoryManager.PackageRepository.GetPackageById(subscriptionEntity.PackageId, false);

			var transactionEntity = new Transaction
			{
				Id = Guid.NewGuid(),
				Amount = package.Price,
				Description = $"Payment for {package.Type} package",
				CreatedAt = DateTime.Now,
				Status = TransactionStatus.Pending,
				SubscriptionId = subscriptionEntity.Id
			};
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);
			await repositoryManager.SaveAsync();

			var vnpay = new VnPayLibrary();
			vnpay.AddRequestData("vnp_Version", "2.1.0");
			vnpay.AddRequestData("vnp_Command", "pay");
			vnpay.AddRequestData("vnp_TmnCode", configuration.GetSection("VNPay").GetSection("TmnCode").Value);
			vnpay.AddRequestData("vnp_Amount", (transactionEntity.Amount * 100).ToString());
			vnpay.AddRequestData("vnp_CreateDate", DateTime.UtcNow.ToString("yyyyMMddHHmmss"));
			vnpay.AddRequestData("vnp_CurrCode", "VND");
			vnpay.AddRequestData("vnp_IpAddr", utils.GetIpAddress());
			vnpay.AddRequestData("vnp_Locale", "vn");
			vnpay.AddRequestData("vnp_OrderType", "other");
			vnpay.AddRequestData("vnp_OrderInfo", $"Payment for order {transactionEntity.Id}");
			vnpay.AddRequestData("vnp_ReturnUrl", configuration.GetSection("VNPay").GetSection("ReturnUrl").Value);
			vnpay.AddRequestData("vnp_TxnRef", transactionEntity.Id.ToString());
			var paymentUrl = vnpay.CreateRequestUrl(configuration.GetSection("VNPay").GetSection("Url").Value, configuration.GetSection("VNPay").GetSection("HashSecret").Value);
			return paymentUrl;

		}

		public async Task<SubscriptionForReturnDto?> GetSubscription(Guid subscriptionId, bool trackChange)
		{
			var subscriptionEntity = await CheckSubscriptionExist(subscriptionId, trackChange);
			return mapper.Map<SubscriptionForReturnDto>(subscriptionEntity);
		}

		public async Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptions(SubscriptionParameters subscriptionParameters, bool trackChange)
		{
			var subscriptionWithMetaData = await repositoryManager.SubscriptionRepository.GetSubscriptions(subscriptionParameters, trackChange);
			var subscriptionDto = mapper.Map<IEnumerable<SubscriptionForReturnDto>>(subscriptionWithMetaData);
			return (subscriptionDto, subscriptionWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, bool trackChange)
		{
			var subscriptionWithMetaData = await repositoryManager.SubscriptionRepository.GetSubscriptionsByUserId(subscriptionParameters, userId, trackChange);
			var subscriptionDto = mapper.Map<IEnumerable<SubscriptionForReturnDto>>(subscriptionWithMetaData);
			return (subscriptionDto, subscriptionWithMetaData.MetaData);
		}
	}
}
