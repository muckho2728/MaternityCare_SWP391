using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IReminderRepository
	{
		Task<IEnumerable<Reminder>> GetReminders(bool trackChange, CancellationToken ct = default);
		Task<Reminder?> GetReminder(int week, bool trackChange, CancellationToken ct = default);
	}
}
