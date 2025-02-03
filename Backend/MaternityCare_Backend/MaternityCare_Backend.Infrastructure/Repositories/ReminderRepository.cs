using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class ReminderRepository : RepositoryBase<Reminder>, IReminderRepository
	{
		public ReminderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public async Task<Reminder?> GetReminder(int week, bool trackChange, CancellationToken ct = default) => await FindByCondition(r => r.Week == week, trackChange).SingleOrDefaultAsync(ct);

		public async Task<IEnumerable<Reminder>> GetReminders(bool trackChange, CancellationToken ct = default) => await FindAll(trackChange).OrderBy(r => r.Week).ToListAsync(ct);
	}
}
