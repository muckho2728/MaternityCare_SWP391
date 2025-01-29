using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;
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
		public async Task<IActionResult> GetSubscriptions([FromQuery] SubscriptionParameters subscriptionParameters)
		{
			var pagedResult = await serviceManager.SubscriptionService.GetSubscriptions(subscriptionParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.subscriptions);
		}

		[HttpGet("users/{userId:guid}")]
		public async Task<IActionResult> GetSubscriptionByUserId(SubscriptionParameters subscriptionParameters, Guid userId)
		{
			var pagedResult = await serviceManager.SubscriptionService.GetSubscriptionsByUserId(subscriptionParameters, userId, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.subscriptions);
		}

		[HttpGet("{subscriptionId:guid}")]
		public async Task<IActionResult> GetSubscriptionById(Guid subscriptionId)
		{
			var subscription = await serviceManager.SubscriptionService.GetSubscription(subscriptionId, false);
			return Ok(subscription);
		}

		[HttpPost]
		public async Task<IActionResult> CreateSubscription([FromForm] SubscriptionForCreationDto subscriptionForCreationDto)
		{
			var paymentUrl = await serviceManager.SubscriptionService.CreateSubscription(subscriptionForCreationDto);
			return Ok(paymentUrl);
		}
	}
}
