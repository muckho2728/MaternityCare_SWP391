﻿using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FeedbackServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GetFeedbacks([FromQuery] FeedbackParameters feedbackParameters, CancellationToken ct = default)
		{
			var pagedResult = await serviceManager.FeedbackService.GetFeedbacks(feedbackParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.feedbacks);
		}

		[HttpGet("{feedbackId:guid}")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GetFeedbackById(Guid feedbackId, CancellationToken ct = default)
		{
			var feedback = await serviceManager.FeedbackService.GetFeedbackById(feedbackId, false, ct);
			return Ok(feedback);
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> CreateFeedback([FromForm] FeedbackForCreationDto feedbackForCreationDto, CancellationToken ct = default)
		{
			await serviceManager.FeedbackService.CreateFeedback(feedbackForCreationDto, ct);
			return StatusCode(201);
		}
	}
}
