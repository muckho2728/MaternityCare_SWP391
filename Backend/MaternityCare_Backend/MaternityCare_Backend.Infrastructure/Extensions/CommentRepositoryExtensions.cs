using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class CommentRepositoryExtensions
	{
		public static IQueryable<Comment> Sort(this IQueryable<Comment> source)
		{
			return source.OrderByDescending(c => c.CreatedAt).ThenByDescending(c => c.UpdatedAt);
		}
	}
}
