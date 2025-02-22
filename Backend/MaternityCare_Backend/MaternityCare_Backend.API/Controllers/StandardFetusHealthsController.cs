using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/standard-fetus-healths")]
	[ApiController]
	public class StandardFetusHealthsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public StandardFetusHealthsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetStandardFetusHealths(CancellationToken ct)
		{
			var standardFetusHealths = await serviceManager.StandardFetusHealthService.GetStandardFetusHealths(ct);
			return Ok(standardFetusHealths);
		}

		[HttpGet("{week:int}")]
		[Authorize]
		public async Task<IActionResult> GetStandardFetusHealth(int week, CancellationToken ct)
		{
			var standardFetusHealth = await serviceManager.StandardFetusHealthService.GetStandardFetusHealth(week, ct);
			return Ok(standardFetusHealth);
		}
	}
}
