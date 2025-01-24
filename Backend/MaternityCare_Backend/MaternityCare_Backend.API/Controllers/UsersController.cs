using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.UserServices.DTOs;
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
		public async Task<IActionResult> GetUsers([FromQuery] UserParameters userParameters)
		{
			var pagedResult = await serviceManager.UserService.GetUsers(userParameters, false);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.users);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetUser([FromRoute] Guid id)
		{
			var user = await serviceManager.UserService.GetUserById(id, false);
			return Ok(user);
		}

		[HttpPut("{id:guid}")]
		public async Task<IActionResult> UpdateUser([FromRoute] Guid id, [FromForm] UserForUpdateDto userForUpdateDto)
		{
			await serviceManager.UserService.UpdateUser(id, userForUpdateDto, true);
			return NoContent();
		}

		[HttpPut("{id:guid}/activation")]
		public async Task<IActionResult> ChangeActiveStatus([FromRoute] Guid id)
		{
			await serviceManager.UserService.ChangeActiveStatus(id);
			return NoContent();
		}

		[HttpPut("{id:guid}/password")]
		public async Task<IActionResult> UpdatePassword([FromRoute] Guid id, [FromForm] UserForUpdatePasswordDto userForUpdatePasswordDto)
		{
			await serviceManager.UserService.UpdatePassword(id, userForUpdatePasswordDto);
			return NoContent();
		}
	}
}
