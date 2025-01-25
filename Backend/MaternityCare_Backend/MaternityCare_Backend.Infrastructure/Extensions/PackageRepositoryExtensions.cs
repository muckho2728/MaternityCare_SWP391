using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class PackageRepositoryExtensions
	{
		public static IQueryable<Package> Filter(this IQueryable<Package> packages, bool isDeleted)
		{
			return packages.Where(p => p.IsDeleted == isDeleted);
		}
	}
}
