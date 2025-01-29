using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.PackageServices.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/packages")]
	[ApiController]
	public class PackagesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public PackagesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetPackages([FromQuery] PackageParameters packageParameters)
		{
			var pagedResult = await serviceManager.PackageService.GetPackages(packageParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.packages);
		}

		[HttpGet("active")]
		public async Task<IActionResult> GetActivePackages([FromQuery] PackageParameters packageParameters)
		{
			var pagedResult = await serviceManager.PackageService.GetActivePackages(packageParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.packages);
		}

		[HttpGet("{packageId:guid}")]
		public async Task<IActionResult> GetPackageById([FromRoute] Guid packageId)
		{
			var package = await serviceManager.PackageService.GetPackageById(packageId, false);
			return Ok(package);
		}

		[HttpPost]
		public async Task<IActionResult> CreatePackage([FromForm] PackageForCreationDto packageForCreationDto)
		{
			var package = await serviceManager.PackageService.CreatePackage(packageForCreationDto);
			return CreatedAtAction(nameof(GetPackageById), new { id = package.Id }, package);
		}

		[HttpPut("{packageId:guid}")]
		public async Task<IActionResult> UpdatePackage([FromRoute] Guid packageId, [FromForm] PackageForUpdateDto packageForUpdateDto)
		{
			await serviceManager.PackageService.UpdatePackage(packageId, packageForUpdateDto, true);
			return NoContent();
		}

		[HttpDelete("{packageId:guid}")]
		public async Task<IActionResult> DeletePackage([FromRoute] Guid packageId)
		{
			await serviceManager.PackageService.DeletePackage(packageId, true);
			return NoContent();
		}
	}
}
