using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class FetusRepositoryExtensions
	{
		public static IQueryable<Fetus> Sort(this IQueryable<Fetus> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}
	}
}
