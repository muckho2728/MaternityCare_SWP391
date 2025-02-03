using MaternityCare_Backend.Domain.RequestFeatures;
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
	}
}
