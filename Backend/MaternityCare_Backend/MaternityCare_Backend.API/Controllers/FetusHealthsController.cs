using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusHealthServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/fetuses/{fetusId:guid}/fetus-healths")]
	[ApiController]
	public class FetusHealthsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public FetusHealthsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetFetusHealthByFetusId([FromRoute] Guid fetusId, [FromQuery] FetusHealthParameters fetusHealthParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.FetusHealthService.GetFetusHealthByFetusId(fetusHealthParameters, fetusId, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.fetusHealths);
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> CreateFetusHealth([FromRoute] Guid fetusId, [FromBody] FetusHealthForCreationDto fetusHealthForCreationDto, CancellationToken ct)
		{
			var (fetusHealth, standardFetusHealth, reminder) = await serviceManager.FetusHealthService.CreateFetusHealth(fetusId, fetusHealthForCreationDto, ct);
			return StatusCode(201, new { fetusHealth, standardFetusHealth, reminder });
		}

		[HttpGet("{week:int}")]
		[Authorize]
		public async Task<IActionResult> GetFetusHealthByFetusIdAndWeek([FromRoute] Guid fetusId, [FromRoute] int week, CancellationToken ct)
		{
			var (fetusHealth, standardFetusHealth, reminder) = await serviceManager.FetusHealthService.GetFetusHealthByFetusIdAndWeek(fetusId, week, ct);
			return Ok(new { fetusHealth, standardFetusHealth, reminder });
		}
	}
}
