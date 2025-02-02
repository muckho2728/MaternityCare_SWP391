using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.UserServices.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/users")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public UsersController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GetUsers([FromQuery] UserParameters userParameters, CancellationToken ct = default)
		{
			var pagedResult = await serviceManager.UserService.GetUsers(userParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.users);
		}

		[HttpGet("{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetUser([FromRoute] Guid userId, CancellationToken ct = default)
		{
			var user = await serviceManager.UserService.GetUserById(userId, false, ct);
			return Ok(user);
		}

		[HttpPut("{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdateUser([FromRoute] Guid userId, [FromForm] UserForUpdateDto userForUpdateDto, CancellationToken ct = default)
		{
			await serviceManager.UserService.UpdateUser(userId, userForUpdateDto, true, ct);
			return NoContent();
		}

		[HttpPut("{userId:guid}/activation")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> ChangeActiveStatus([FromRoute] Guid userId, CancellationToken ct = default)
		{
			await serviceManager.UserService.ChangeActiveStatus(userId, ct);
			return NoContent();
		}

		[HttpPut("{userId:guid}/password")]
		[Authorize]
		public async Task<IActionResult> UpdatePassword([FromRoute] Guid userId, [FromForm] UserForUpdatePasswordDto userForUpdatePasswordDto, CancellationToken ct = default)
		{
			await serviceManager.UserService.UpdatePassword(userId, userForUpdatePasswordDto, ct);
			return NoContent();
		}
	}
}
