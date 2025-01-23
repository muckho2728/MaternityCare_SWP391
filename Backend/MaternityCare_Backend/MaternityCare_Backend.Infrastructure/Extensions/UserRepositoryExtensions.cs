using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class UserRepositoryExtensions
	{
		public static IQueryable<User> Search(this IQueryable<User> users, string searchTerm)
		{
			if (string.IsNullOrWhiteSpace(searchTerm)) return users;
			var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
			return users.Where(u => u.FullName.ToLower().Contains(lowerCaseSearchTerm));
		}

		public static IQueryable<User> Filter(this IQueryable<User> users, bool isActive) => users.Where(u => u.IsActive == isActive);
	}
}
