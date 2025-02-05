using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/reminders")]
	[ApiController]
	public class RemindersController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public RemindersController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetReminders(CancellationToken ct)
		{
			var reminders = await serviceManager.ReminderService.GetReminders(false, ct);
			return Ok(reminders);
		}

		[HttpGet("{week:int}")]
		[Authorize]
		public async Task<IActionResult> GetReminder([FromRoute] int week, CancellationToken ct)
		{
			var reminder = await serviceManager.ReminderService.GetReminder(week, false, ct);
			return Ok(reminder);
		}
	}
}
