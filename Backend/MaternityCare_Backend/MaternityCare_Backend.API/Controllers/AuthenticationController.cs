using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.UserServices.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/authentications")]
	[ApiController]
	public class AuthenticationController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AuthenticationController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register([FromForm] UserForCreationDto userForCreationDto, CancellationToken ct)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			await serviceManager.UserService.CreateUser(userForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromForm] UserForAuthenticationDto userForAuth, CancellationToken ct)
		{
			if (await serviceManager.UserService.ValidateUser(userForAuth, ct))
			{
				var token = await serviceManager.UserService.CreateToken(true);
				return Ok(token);
			}
			return Unauthorized();
		}

		[HttpGet("current-user")]
		[Authorize]
		public async Task<IActionResult> GetCurrentUser(CancellationToken ct)
		{
			var token = HttpContext.Request.Headers["Authorization"].ToString().Split(" ")[1];
			var user = await serviceManager.UserService.GetUserByToken(token, false, ct);
			return Ok(user);
		}

		[HttpGet("email-verification")]
		public async Task<IActionResult> ConfirmEmail([FromQuery] string token, [FromQuery] string email, CancellationToken ct)
		{
			await serviceManager.UserService.ConfirmEmail(token, email, ct);
			return Ok("Email verified successfully");
		}

		[HttpPost("password-forgeting")]
		public async Task<IActionResult> SendResetPasswordToken([FromForm] string email, CancellationToken ct)
		{
			await serviceManager.UserService.SendResetPasswordToken(email, ct);
			return Ok();
		}

		[HttpPut("password-forgeting")]
		public async Task<IActionResult> ResetPassword([FromForm] UserForResetPasswordDto userForResetPasswordDto, CancellationToken ct)
		{
			await serviceManager.UserService.ResetPassword(userForResetPasswordDto, ct);
			return Ok();
		}
	}
}
