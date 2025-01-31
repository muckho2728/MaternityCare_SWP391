using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.AppointmentServices.DTOs;
using MaternityCare_Backend.Service.IServices;
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
		public async Task<IActionResult> GetAppointments([FromQuery] AppointmentParameters appointmentParameters)
		{
			var pagedResult = await serviceManager.AppointmentService.GetAppointments(appointmentParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.appointments);
		}

		[HttpGet("{appointmentId:guid}")]
		public async Task<IActionResult> GetAppointment([FromRoute] Guid appointmentId)
		{
			var appointment = await serviceManager.AppointmentService.GetAppointment(appointmentId, false);
			return Ok(appointment);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAppointment([FromForm] AppointmentForCreationDto appointmentForCreationDto)
		{
			await serviceManager.AppointmentService.CreateAppointment(appointmentForCreationDto);
			return StatusCode(201);
		}

		[HttpDelete("{appointmentId:guid}")]
		public async Task<IActionResult> DeleteAppointment([FromRoute] Guid appointmentId)
		{
			await serviceManager.AppointmentService.DeleteAppointment(appointmentId, false);
			return NoContent();
		}

		[HttpGet("excel-generating")]
		public async Task<IActionResult> GenerateExcel([FromQuery] DateOnly date)
		{
			var fileContents = await serviceManager.AppointmentService.GenerateExcel(date);
			return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{DateOnly.FromDateTime(DateTime.Now)}.xlsx");
		}
	}
}
