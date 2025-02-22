using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class AppointmentsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AppointmentsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("users/{userId:guid}/appointments")]
		[Authorize]
		public async Task<IActionResult> GetAppointments([FromRoute] Guid userId, [FromQuery] AppointmentParameters appointmentParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.AppointmentService.GetAppointments(userId, appointmentParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.appointments);
		}

		[HttpGet("users/{userId:guid}/slots/{slotId:guid}/appointments")]
		[Authorize]
		public async Task<IActionResult> GetAppointment([FromRoute] Guid userId, Guid slotId, CancellationToken ct)
		{
			var appointment = await serviceManager.AppointmentService.GetAppointment(userId, slotId, ct);
			return Ok(appointment);
		}

		[HttpPost("users/{userId:guid}/slots/{slotId:guid}/appointments")]
		[Authorize]
		public async Task<IActionResult> CreateAppointment([FromRoute] Guid userId, [FromRoute] Guid slotId, CancellationToken ct)
		{
			await serviceManager.AppointmentService.CreateAppointment(userId, slotId, ct);
			return StatusCode(201);
		}

		[HttpDelete("users/{userId:guid}/slots/{slotId:guid}/appointments")]
		[Authorize]
		public async Task<IActionResult> DeleteAppointment([FromRoute] Guid userId, [FromRoute] Guid slotId, CancellationToken ct)
		{
			await serviceManager.AppointmentService.DeleteAppointment(userId, slotId, ct);
			return NoContent();
		}

		[HttpGet("appointments/today-appointment-excel-generating")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GenerateExcel([FromQuery] DateOnly date, CancellationToken ct = default)
		{
			var fileContents = await serviceManager.AppointmentService.GenerateExcel(date, ct);
			return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{DateOnly.FromDateTime(DateTime.Now)}.xlsx");
		}
	}
}
