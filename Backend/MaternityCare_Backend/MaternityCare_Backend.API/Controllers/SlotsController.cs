using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.SlotServices.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/doctors/{doctorId:guid}/slots")]
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
		public async Task<IActionResult> GetSlots([FromRoute] Guid doctorId, [FromQuery] SlotParameters slotParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.SlotService.GetSlots(doctorId, slotParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.slots);
		}

		[HttpGet("{slotId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetSlot([FromRoute] Guid doctorId, [FromRoute] Guid slotId, CancellationToken ct)
		{
			var slot = await serviceManager.SlotService.GetSlot(doctorId, slotId, false, ct);
			return Ok(slot);
		}

		[HttpPost]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> CreateSlot([FromRoute] Guid doctorId, [FromBody] SlotForCreationDto slotForCreationDto, CancellationToken ct)
		{
			await serviceManager.SlotService.CreateSlot(doctorId, slotForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpDelete("{slotId:guid}")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> DeleteSlot([FromRoute] Guid doctorId, [FromRoute] Guid slotId, CancellationToken ct)
		{
			await serviceManager.SlotService.DeleteSlot(doctorId, slotId, false, ct);
			return NoContent();
		}
	}
}
