﻿using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/tags")]
	[ApiController]
	public class TagsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public TagsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetTags(CancellationToken ct)
		{
			var tags = await serviceManager.TagService.GetTags(ct);
			return Ok(tags);
		}

		[HttpGet("{tagId:guid}")]
		public async Task<IActionResult> GetTag(Guid tagId, CancellationToken ct)
		{
			var tag = await serviceManager.TagService.GetTag(tagId, ct);
			return Ok(tag);
		}
	}
}
