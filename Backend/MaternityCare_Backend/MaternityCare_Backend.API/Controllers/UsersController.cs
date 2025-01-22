using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.IServices;
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
		public async Task<IActionResult> GetUser(Guid id)
		{
			var user = await serviceManager.UserService.GetUserById(id, false);
			return Ok(user);
		}
	}
}
