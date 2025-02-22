using MaternityCare_Backend.Service.ReminderServices.DTOs;

namespace MaternityCare_Backend.Service.ReminderServices
{
	public interface IReminderService
	{
		Task<IEnumerable<ReminderForReturnDto>> GetReminders(CancellationToken ct);
		Task<ReminderForReturnDto?> GetReminder(int week, CancellationToken ct);
	}
}
