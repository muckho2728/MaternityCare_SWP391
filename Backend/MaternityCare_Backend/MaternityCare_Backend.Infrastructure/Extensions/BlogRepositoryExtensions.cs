using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class BlogRepositoryExtensions
	{
		public static IQueryable<Blog> Filter(this IQueryable<Blog> blogs, Guid tagId, bool isActive)
		{
			if (tagId != Guid.Empty)
			{
				blogs = blogs.Where(b => b.TagId == tagId);
			}
			blogs = blogs.Where(b => b.IsActive == isActive);
			return blogs;
		}

		public static IQueryable<Blog> Search(this IQueryable<Blog> blogs, string searchTitle) => blogs.Where(b => b.Title.ToLower().Contains(searchTitle.ToLower() ?? string.Empty, StringComparison.OrdinalIgnoreCase));

		public static IQueryable<Blog> Sort(this IQueryable<Blog> blogs) => blogs.OrderByDescending(b => b.CreatedAt).ThenByDescending(b => b.UpdatedAt);

	}
}
