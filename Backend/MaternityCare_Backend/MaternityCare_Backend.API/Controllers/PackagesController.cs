﻿using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.PackageServices.DTOs;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GetPackages([FromQuery] PackageParameters packageParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.PackageService.GetPackages(packageParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.packages);
		}

		[HttpGet("active")]
		[Authorize]
		public async Task<IActionResult> GetActivePackages([FromQuery] PackageParameters packageParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.PackageService.GetActivePackages(packageParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.packages);
		}

		[HttpGet("{packageId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetPackageById([FromRoute] Guid packageId, CancellationToken ct)
		{
			var package = await serviceManager.PackageService.GetPackageById(packageId, false, ct);
			return Ok(package);
		}

		[HttpPost]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> CreatePackage([FromForm] PackageForCreationDto packageForCreationDto, CancellationToken ct)
		{
			await serviceManager.PackageService.CreatePackage(packageForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{packageId:guid}")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> UpdatePackage([FromRoute] Guid packageId, [FromForm] PackageForUpdateDto packageForUpdateDto, CancellationToken ct)
		{
			await serviceManager.PackageService.UpdatePackage(packageId, packageForUpdateDto, true, ct);
			return NoContent();
		}

		[HttpDelete("{packageId:guid}")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> DeletePackage([FromRoute] Guid packageId, CancellationToken ct)
		{
			await serviceManager.PackageService.DeletePackage(packageId, true, ct);
			return NoContent();
		}
	}
}
