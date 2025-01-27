using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class TransactionRepositoryExtensions
	{
		public static IQueryable<Transaction> Filter(this IQueryable<Transaction> users, TransactionStatus status) => users.Where(u => u.Status == status);

		public static IQueryable<Transaction> Sort(this IQueryable<Transaction> users)
		{
			return users.OrderByDescending(u => u.CreatedAt);
		}
	}
}
