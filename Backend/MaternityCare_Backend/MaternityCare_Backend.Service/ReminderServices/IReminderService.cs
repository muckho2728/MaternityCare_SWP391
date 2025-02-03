using MaternityCare_Backend.Service.ReminderServices.DTOs;

namespace MaternityCare_Backend.Service.ReminderServices
{
	public interface IReminderService
	{
		Task<IEnumerable<ReminderForReturnDto>> GetReminders(bool trackChange, CancellationToken ct);
		Task<ReminderForReturnDto?> GetReminder(int week, bool trackChange, CancellationToken ct);
	}
}
