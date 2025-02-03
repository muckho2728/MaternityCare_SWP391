using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.AppointmentServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/appointments")]
	[ApiController]
	public class AppointmentsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AppointmentsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetAppointments([FromQuery] AppointmentParameters appointmentParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.AppointmentService.GetAppointments(appointmentParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.appointments);
		}

		[HttpGet("{appointmentId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetAppointment([FromRoute] Guid appointmentId, CancellationToken ct)
		{
			var appointment = await serviceManager.AppointmentService.GetAppointment(appointmentId, false, ct);
			return Ok(appointment);
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> CreateAppointment([FromForm] AppointmentForCreationDto appointmentForCreationDto, CancellationToken ct)
		{
			await serviceManager.AppointmentService.CreateAppointment(appointmentForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpDelete("{appointmentId:guid}")]
		[Authorize]
		public async Task<IActionResult> DeleteAppointment([FromRoute] Guid appointmentId, CancellationToken ct)
		{
			await serviceManager.AppointmentService.DeleteAppointment(appointmentId, false, ct);
			return NoContent();
		}

		[HttpGet("excel-generating")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GenerateExcel([FromQuery] DateOnly date, CancellationToken ct = default)
		{
			var fileContents = await serviceManager.AppointmentService.GenerateExcel(date, ct);
			return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{DateOnly.FromDateTime(DateTime.Now)}.xlsx");
		}
	}
}
