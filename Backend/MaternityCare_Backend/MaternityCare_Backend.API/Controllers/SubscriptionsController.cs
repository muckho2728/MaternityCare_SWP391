using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/subscriptions")]
	[ApiController]
	public class SubscriptionsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public SubscriptionsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetSubscriptions([FromQuery] SubscriptionParameters subscriptionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.SubscriptionService.GetSubscriptions(subscriptionParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.subscriptions);
		}

		[HttpGet("users/{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetSubscriptionByUserId([FromBody] SubscriptionParameters subscriptionParameters, [FromRoute] Guid userId, CancellationToken ct)
		{
			var pagedResult = await serviceManager.SubscriptionService.GetSubscriptionsByUserId(subscriptionParameters, userId, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.subscriptions);
		}

		[HttpGet("{subscriptionId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetSubscriptionById([FromRoute] Guid subscriptionId, CancellationToken ct)
		{
			var subscription = await serviceManager.SubscriptionService.GetSubscription(subscriptionId, false, ct);
			return Ok(subscription);
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> CreateSubscription([FromBody] SubscriptionForCreationDto subscriptionForCreationDto, CancellationToken ct)
		{
			var paymentUrl = await serviceManager.SubscriptionService.CreateSubscription(subscriptionForCreationDto, ct);
			return Ok(paymentUrl);
		}
	}
}
