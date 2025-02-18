using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class SlotRepositoryExtensions
	{
		public static IQueryable<Slot> Filter(this IQueryable<Slot> slots, DateOnly date) => slots.Where(s => s.Date >= date);

		public static IQueryable<Slot> Sort(this IQueryable<Slot> slots) => slots.OrderBy(s => s.StartTime);
	}
}
