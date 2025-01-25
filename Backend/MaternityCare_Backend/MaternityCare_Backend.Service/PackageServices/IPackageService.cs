using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.PackageServices.DTOs;

namespace MaternityCare_Backend.Service.PackageServices
{
	public interface IPackageService
	{
		Task<PackageForReturnDto> CreatePackage(PackageForCreationDto packageForCreationDto);
		Task UpdatePackage(Guid id, PackageForUpdateDto packageForUpdateDto, bool trackChange);
		Task DeletePackage(Guid id, bool trackChange);
		Task<PackageForReturnDto?> GetPackageById(Guid id, bool trackChange);
		Task<(IEnumerable<PackageForReturnDto> packages, MetaData metaData)> GetPackages(PackageParameters packageParameters, bool trackChange);
		Task<(IEnumerable<PackageForReturnDto> packages, MetaData metaData)> GetActivePackages(PackageParameters packageParameters, bool trackChange);

	}
}
