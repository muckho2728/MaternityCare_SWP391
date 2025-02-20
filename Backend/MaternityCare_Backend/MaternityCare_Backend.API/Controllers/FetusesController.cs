using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/users/{userId:guid}/fetuses")]
	[ApiController]
	public class FetusesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public FetusesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetFetusesByUserId([FromQuery] FetusParameters fetusParameters, [FromRoute] Guid userId, CancellationToken ct)
		{
			var pagedResult = await serviceManager.FetusService.GetFetusesByUserId(fetusParameters, userId, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.fetuses);
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> CreateFetus([FromRoute] Guid userId, [FromBody] FetusForCreationDto fetusForCreationDto, CancellationToken ct)
		{
			await serviceManager.FetusService.CreateFetus(userId, fetusForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{fetusId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdateFetus([FromRoute] Guid userId, [FromRoute] Guid fetusId, [FromBody] FetusForUpdateDto fetusForUpdateDto, CancellationToken ct)
		{
			await serviceManager.FetusService.UpdateFetus(fetusId, fetusForUpdateDto, true, ct);
			return NoContent();
		}
	}
}
