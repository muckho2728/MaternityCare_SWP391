using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class SubscriptionsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public SubscriptionsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("subscriptions")]
		[Authorize]
		public async Task<IActionResult> GetSubscriptions([FromQuery] SubscriptionParameters subscriptionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.SubscriptionService.GetSubscriptions(subscriptionParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.subscriptions);
		}

		[HttpGet("users/{userId:guid}/subscriptions")]
		[Authorize]
		public async Task<IActionResult> GetSubscriptionByUserId([FromBody] SubscriptionParameters subscriptionParameters, [FromRoute] Guid userId, CancellationToken ct)
		{
			var pagedResult = await serviceManager.SubscriptionService.GetSubscriptionsByUserId(subscriptionParameters, userId, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.subscriptions);
		}

		[HttpGet("subscriptions/{subscriptionId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetSubscriptionById([FromRoute] Guid subscriptionId, CancellationToken ct)
		{
			var subscription = await serviceManager.SubscriptionService.GetSubscription(subscriptionId, ct);
			return Ok(subscription);
		}

		[HttpPost("users/{userId:guid}/packages/{packageId:guid}/subscriptions")]
		[Authorize]
		public async Task<IActionResult> CreateSubscription([FromRoute] Guid userId, [FromRoute] Guid packageId, CancellationToken ct)
		{
			var paymentUrl = await serviceManager.SubscriptionService.CreateSubscription(userId, packageId, ct);
			return Ok(paymentUrl);
		}
	}
}
