using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class FetusHealthRepositoryExtensions
	{
		public static IQueryable<FetusHealth> Sort(this IQueryable<FetusHealth> source)
		{
			return source.OrderBy(x => x.Week);
		}
	}
}
