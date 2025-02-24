using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AIChatsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AIChatsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		//[HttpPost]
		//public async Task<IActionResult> Asking([FromForm] string message)
		//{
		//	var answer = await serviceManager.AIChatService.Asking(message);
		//	return Ok(answer);
		//}
	}
}
