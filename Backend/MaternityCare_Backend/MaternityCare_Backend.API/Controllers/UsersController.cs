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
		private readonly IConfiguration configuration;
		private readonly IHttpContextAccessor httpContextAccessor;

		public UsersController(IServiceManager serviceManager, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
		{
			this.serviceManager = serviceManager;
			this.configuration = configuration;
			this.httpContextAccessor = httpContextAccessor;
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
		public async Task<IActionResult> ChangeActiveStatus(Guid id)
		{
			await serviceManager.UserService.ChangeActiveStatus(id);
			return NoContent();
		}

		[HttpGet("email-verification")]
		public async Task<IActionResult> ConfirmEmail([FromQuery] string token, [FromQuery] string email)
		{
			await serviceManager.UserService.ConfirmEmail(token, email);
			return Ok();
		}

		[HttpPost("reset-password")]
		public async Task<IActionResult> SendResetPasswordToken([FromForm] string email)
		{
			await serviceManager.UserService.SendResetPasswordToken(email);
			return Ok();
		}

		[HttpPut("reset-password")]
		public async Task<IActionResult> ResetPassword([FromForm] UserForResetPasswordDto userForResetPasswordDto)
		{
			await serviceManager.UserService.ResetPassword(userForResetPasswordDto);
			return Ok();
		}
	}
}
