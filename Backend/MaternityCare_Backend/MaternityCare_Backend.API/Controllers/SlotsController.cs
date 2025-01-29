﻿using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.SlotServices.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/slots")]
	[ApiController]
	public class SlotsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public SlotsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetSlots([FromQuery] SlotParameters slotParameters)
		{
			var pagedResult = await serviceManager.SlotService.GetSlots(slotParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.slots);
		}

		[HttpGet("{slotId:guid}")]
		public async Task<IActionResult> GetSlot([FromRoute] Guid slotId)
		{
			var slot = await serviceManager.SlotService.GetSlot(slotId, false);
			return Ok(slot);
		}

		[HttpPost]
		public async Task<IActionResult> CreateSlot([FromForm] SlotForCreationDto slotForCreationDto)
		{
			await serviceManager.SlotService.CreateSlot(slotForCreationDto);
			return StatusCode(201);
		}

		[HttpDelete("{slotId:guid}")]
		public async Task<IActionResult> DeleteSlot([FromRoute] Guid slotId)
		{
			await serviceManager.SlotService.DeleteSlot(slotId);
			return NoContent();
		}
	}
}
