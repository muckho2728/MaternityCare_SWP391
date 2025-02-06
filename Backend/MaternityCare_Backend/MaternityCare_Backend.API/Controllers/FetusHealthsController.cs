using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusHealthServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/{fetusId:guid}/fetus-healths")]
	[ApiController]
	public class FetusHealthsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public FetusHealthsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetFetusHealthByFetusId([FromRoute] Guid fetusId, FetusHealthParameters fetusHealthParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.FetusHealthService.GetFetusHealthByFetusId(fetusHealthParameters, fetusId, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.fetusHealths);
		}

		[HttpPost]
		public async Task<IActionResult> CreateFetusHealth([FromRoute] Guid fetusId, [FromBody] FetusHealthForCreationDto fetusHealthForCreationDto, CancellationToken ct)
		{
			var (standardFetusHealth, reminder) = await serviceManager.FetusHealthService.CreateFetusHealth(fetusHealthForCreationDto, ct);
			return StatusCode(201, new { standardFetusHealth, reminder });
		}
	}
}
