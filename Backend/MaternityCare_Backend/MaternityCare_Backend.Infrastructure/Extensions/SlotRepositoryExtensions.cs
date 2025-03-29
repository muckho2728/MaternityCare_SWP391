using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class SlotRepositoryExtensions
	{
		public static IQueryable<Slot> Filter(this IQueryable<Slot> slots)
		{
			return slots.Where(s => s.Date > DateOnly.FromDateTime(DateTime.Now));
		}

		public static IQueryable<Slot> Sort(this IQueryable<Slot> slots) => slots.OrderBy(s => s.StartTime);
	}
}
