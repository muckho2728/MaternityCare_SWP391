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
		public async Task<IActionResult> GetUsers([FromQuery] UserParameters userParameters)
		{
			var pagedResult = await serviceManager.UserService.GetUsers(userParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.users);
		}

		[HttpGet("{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetUser([FromRoute] Guid userId)
		{
			var user = await serviceManager.UserService.GetUserById(userId, false);
			return Ok(user);
		}

		[HttpPut("{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdateUser([FromRoute] Guid userId, [FromForm] UserForUpdateDto userForUpdateDto)
		{
			await serviceManager.UserService.UpdateUser(userId, userForUpdateDto, true);
			return NoContent();
		}

		[HttpPut("{userId:guid}/activation")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> ChangeActiveStatus([FromRoute] Guid userId)
		{
			await serviceManager.UserService.ChangeActiveStatus(userId);
			return NoContent();
		}

		[HttpPut("{userId:guid}/password")]
		[Authorize]
		public async Task<IActionResult> UpdatePassword([FromRoute] Guid userId, [FromForm] UserForUpdatePasswordDto userForUpdatePasswordDto)
		{
			await serviceManager.UserService.UpdatePassword(userId, userForUpdatePasswordDto);
			return NoContent();
		}
	}
}
