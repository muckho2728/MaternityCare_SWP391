using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.DoctorServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/doctors")]
	[ApiController]
	public class DoctorsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public DoctorsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetDoctors([FromQuery] DoctorParameters doctorParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.DoctorService.GetDoctor(doctorParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.doctors);
		}

		[HttpGet("{doctorId}")]
		[Authorize]
		public async Task<IActionResult> GetDoctor(Guid doctorId, CancellationToken ct)
		{
			var doctor = await serviceManager.DoctorService.GetDoctorById(doctorId, false, ct);
			return Ok(doctor);
		}

		[HttpPost]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> CreateDoctor([FromBody] DoctorForCreationDto doctorForCreationDto, CancellationToken ct)
		{
			await serviceManager.DoctorService.CreateDoctor(doctorForCreationDto, ct);
			return Ok();
		}

		[HttpPut("{doctorId}")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> UpdateDoctor(Guid doctorId, [FromBody] DoctorForUpdateDto doctorForUpdateDto, CancellationToken ct)
		{
			await serviceManager.DoctorService.UpdateDoctor(doctorId, doctorForUpdateDto, false, ct);
			return Ok();
		}

		[HttpDelete("{doctorId}")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> DeleteDoctor(Guid doctorId, CancellationToken ct)
		{
			await serviceManager.DoctorService.DeleteDoctor(doctorId, false, ct);
			return Ok();
		}
	}
}
