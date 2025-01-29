using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FeedbackServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/feedbacks")]
	[ApiController]
	public class FeedbacksController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public FeedbacksController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetFeedbacks([FromQuery] FeedbackParameters feedbackParameters)
		{
			var pagedResult = await serviceManager.FeedbackService.GetFeedbacks(feedbackParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.feedbacks);
		}

		[HttpGet("{feedbackId:guid}")]
		public async Task<IActionResult> GetFeedbackById(Guid feedbackId)
		{
			var feedback = await serviceManager.FeedbackService.GetFeedbackById(feedbackId, false);
			return Ok(feedback);
		}

		[HttpPost]
		public async Task<IActionResult> CreateFeedback([FromForm] FeedbackForCreationDto feedbackForCreationDto)
		{
			var feedback = await serviceManager.FeedbackService.CreateFeedback(feedbackForCreationDto);
			return CreatedAtAction(nameof(GetFeedbackById), new { id = feedback.Id }, feedback);
		}
	}
}
