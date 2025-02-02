using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class PackageRepository : RepositoryBase<Package>, IPackageRepository
	{
		public PackageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreatePackage(Package package) => Create(package);

		public async Task<PagedList<Package>> GetActivePackages(PackageParameters packageParameters, bool trackChange, CancellationToken ct = default)
		{
			var packageEntities = FindByCondition(p => !p.IsDeleted, trackChange);
			return await PagedList<Package>.ToPagedList(packageEntities, packageParameters.PageNumber, packageParameters.PageSize, ct);
		}

		public Task<Package?> GetPackageById(Guid id, bool trackChange, CancellationToken ct = default) => FindByCondition(p => p.Id == id, trackChange).SingleOrDefaultAsync(ct);

		public async Task<PagedList<Package>> GetPackages(PackageParameters packageParameters, bool trackChange, CancellationToken ct = default)
		{
			var packageEntities = FindAll(trackChange)
				.Filter(packageParameters.IsDeleted);
			return await PagedList<Package>.ToPagedList(packageEntities, packageParameters.PageNumber, packageParameters.PageSize, ct);
		}
	}
}
