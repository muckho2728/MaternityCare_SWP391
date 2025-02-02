using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.PackageServices.DTOs;

namespace MaternityCare_Backend.Service.PackageServices
{
	public interface IPackageService
	{
		Task<PackageForReturnDto> CreatePackage(PackageForCreationDto packageForCreationDto, CancellationToken ct = default);
		Task UpdatePackage(Guid id, PackageForUpdateDto packageForUpdateDto, bool trackChange, CancellationToken ct = default);
		Task DeletePackage(Guid id, bool trackChange, CancellationToken ct = default);
		Task<PackageForReturnDto?> GetPackageById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<PackageForReturnDto> packages, MetaData metaData)> GetPackages(PackageParameters packageParameters, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<PackageForReturnDto> packages, MetaData metaData)> GetActivePackages(PackageParameters packageParameters, bool trackChange, CancellationToken ct = default);

	}
}
