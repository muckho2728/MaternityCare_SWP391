using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	public class PackageRepository : RepositoryBase<Package>, IPackageRepository
	{
		public PackageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreatePackage(Package package) => Create(package);

		public Task<PagedList<Package>> GetActivePackages(PackageParameters packageParameters, bool trackChange)
		{
			var packageEntities = FindByCondition(p => !p.IsDeleted, trackChange);
			return PagedList<Package>.ToPagedList(packageEntities, packageParameters.PageNumber, packageParameters.PageSize);
		}

		public Task<Package?> GetPackageById(Guid id, bool trackChange) => FindByCondition(p => p.Id == id, trackChange).SingleOrDefaultAsync();

		public async Task<PagedList<Package>> GetPackages(PackageParameters packageParameters, bool trackChange)
		{
			var packageEntities = FindAll(trackChange)
				.Filter(packageParameters.IsDeleted);
			return await PagedList<Package>.ToPagedList(packageEntities, packageParameters.PageNumber, packageParameters.PageSize);
		}
	}
}
