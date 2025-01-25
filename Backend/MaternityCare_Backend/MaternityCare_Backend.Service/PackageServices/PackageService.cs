using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.PackageServices.DTOs;

namespace MaternityCare_Backend.Service.PackageServices
{
	internal sealed class PackageService : IPackageService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public PackageService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		private async Task<Package?> CheckPackageExist(Guid id, bool trackChange)
		{
			var package = await repositoryManager.PackageRepository.GetPackageById(id, trackChange);
			if (package == null) throw new PackageNotFoundException();
			return package;
		}
		public async Task<PackageForReturnDto> CreatePackage(PackageForCreationDto packageForCreationDto)
		{
			var packageEntity = mapper.Map<Package>(packageForCreationDto);
			packageEntity.CreatedAt = DateTime.Now;
			packageEntity.IsDeleted = false;
			repositoryManager.PackageRepository.CreatePackage(packageEntity);
			await repositoryManager.SaveAsync();
			return mapper.Map<PackageForReturnDto>(packageEntity);
		}

		public async Task DeletePackage(Guid id, bool trackChange)
		{
			var packageEntity = await CheckPackageExist(id, trackChange);
			packageEntity.IsDeleted = true;
			packageEntity.DeletedAt = DateTime.Now;
			await repositoryManager.SaveAsync();
		}

		public async Task<(IEnumerable<PackageForReturnDto> packages, MetaData metaData)> GetActivePackages(PackageParameters packageParameters, bool trackChange)
		{
			var packageWithMetaData = await repositoryManager.PackageRepository.GetActivePackages(packageParameters, trackChange);
			var packageDto = mapper.Map<IEnumerable<PackageForReturnDto>>(packageWithMetaData);
			return (packageDto, packageWithMetaData.MetaData);
		}

		public async Task<PackageForReturnDto?> GetPackageById(Guid id, bool trackChange)
		{
			var packageEntity = await CheckPackageExist(id, trackChange);
			return mapper.Map<PackageForReturnDto>(packageEntity);
		}

		public async Task<(IEnumerable<PackageForReturnDto> packages, MetaData metaData)> GetPackages(PackageParameters packageParameters, bool trackChange)
		{
			var packageWithMetaData = await repositoryManager.PackageRepository.GetPackages(packageParameters, trackChange);
			var packageDto = mapper.Map<IEnumerable<PackageForReturnDto>>(packageWithMetaData);
			return (packageDto, packageWithMetaData.MetaData);
		}

		public async Task UpdatePackage(Guid id, PackageForUpdateDto packageForUpdateDto, bool trackChange)
		{
			var packageEntity = await CheckPackageExist(id, trackChange);
			mapper.Map(packageForUpdateDto, packageEntity);
			packageEntity.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync();
		}
	}
}
