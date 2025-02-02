using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/transactions")]
	[ApiController]
	public class TransactionsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public TransactionsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetTransactions([FromQuery] TransactionParameters transactionParameters, CancellationToken ct = default)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactions(transactionParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}

		[HttpGet("{userId:guid}")]
		public async Task<IActionResult> GetTransactionsByUserId([FromRoute] Guid userId, [FromQuery] TransactionParameters transactionParameters, CancellationToken ct = default)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactionsByUserId(userId, transactionParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}

		[HttpGet("ipn")]
		public async Task<IActionResult> IPN(CancellationToken ct = default)
		{
			var result = await serviceManager.TransactionService.IPNAsync(Request.Query, ct);
			return Ok(result);
		}
	}
}
