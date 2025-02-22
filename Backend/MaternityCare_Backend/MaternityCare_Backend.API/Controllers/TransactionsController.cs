using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GetTransactions([FromQuery] TransactionParameters transactionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactions(transactionParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}

		[HttpGet("{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetTransactionsByUserId([FromRoute] Guid userId, [FromQuery] TransactionParameters transactionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactionsByUserId(userId, transactionParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}

		[HttpGet("ipn")]
		public async Task<IActionResult> IPN(CancellationToken ct)
		{
			var result = await serviceManager.TransactionService.IPNAsync(Request.Query, ct);
			return Ok(result);
		}
	}
}
