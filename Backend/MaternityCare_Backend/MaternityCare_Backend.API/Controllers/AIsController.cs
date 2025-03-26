using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Service.AIServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AIsController : ControllerBase
	{
		private readonly IAIService aIService;

		public AIsController(IAIService aIService)
		{
			this.aIService = aIService;
		}

		[HttpPut]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> UpdateBlockList(CancellationToken ct = default)
		{
			await aIService.AddOrUpdateBlockList(ct);
			return NoContent();
		}
	}
}
