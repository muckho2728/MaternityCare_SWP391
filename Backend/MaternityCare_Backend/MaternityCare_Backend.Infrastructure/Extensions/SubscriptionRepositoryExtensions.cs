using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class SubscriptionRepositoryExtensions
	{
		public static IQueryable<Subscription> Filter(this IQueryable<Subscription> subscriptions, DateOnly startDate, DateOnly endDate)
		{
			return subscriptions.Where(s => s.StartDate >= startDate && s.EndDate <= endDate);
		}

		public static IQueryable<Subscription> Sort(this IQueryable<Subscription> subscriptions)
		{
			return subscriptions.OrderBy(s => s.StartDate);
		}
	}
}
