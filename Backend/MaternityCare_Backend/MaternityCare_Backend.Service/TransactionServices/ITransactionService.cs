using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.TransactionServices.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.Service.TransactionServices
{
	public interface ITransactionService
	{
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange);
		Task<IActionResult> IPNAsync(IQueryCollection query);
	}
}
