using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IPackageRepository
	{
		public void CreatePackage(Package package);
		public Task<PagedList<Package>> GetPackages(PackageParameters packageParameters, bool trackChange);
		public Task<PagedList<Package>> GetActivePackages(PackageParameters packageParameters, bool trackChange);
		public Task<Package?> GetPackageById(Guid id, bool trackChange);
	}
}
