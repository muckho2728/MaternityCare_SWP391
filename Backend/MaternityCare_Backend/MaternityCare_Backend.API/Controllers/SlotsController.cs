using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.SlotServices.DTOs;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize]
		public async Task<IActionResult> GetSlots([FromQuery] SlotParameters slotParameters, CancellationToken ct = default)
		{
			var pagedResult = await serviceManager.SlotService.GetSlots(slotParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.slots);
		}

		[HttpGet("{slotId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetSlot([FromRoute] Guid slotId, CancellationToken ct = default)
		{
			var slot = await serviceManager.SlotService.GetSlot(slotId, false, ct);
			return Ok(slot);
		}

		[HttpPost]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> CreateSlot([FromForm] SlotForCreationDto slotForCreationDto, CancellationToken ct = default)
		{
			await serviceManager.SlotService.CreateSlot(slotForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpDelete("{slotId:guid}")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> DeleteSlot([FromRoute] Guid slotId, CancellationToken ct = default)
		{
			await serviceManager.SlotService.DeleteSlot(slotId, ct);
			return NoContent();
		}
	}
}
