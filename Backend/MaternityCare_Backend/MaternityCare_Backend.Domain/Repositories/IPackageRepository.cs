using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IPackageRepository
	{
		void CreatePackage(Package package);
		Task<PagedList<Package>> GetPackages(PackageParameters packageParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Package>> GetActivePackages(PackageParameters packageParameters, bool trackChange, CancellationToken ct = default);
		Task<Package?> GetPackageById(Guid id, bool trackChange, CancellationToken ct = default);
	}
}
