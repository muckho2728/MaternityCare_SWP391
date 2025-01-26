using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IPackageRepository
	{
		void CreatePackage(Package package);
		Task<PagedList<Package>> GetPackages(PackageParameters packageParameters, bool trackChange);
		Task<PagedList<Package>> GetActivePackages(PackageParameters packageParameters, bool trackChange);
		Task<Package?> GetPackageById(Guid id, bool trackChange);
	}
}
