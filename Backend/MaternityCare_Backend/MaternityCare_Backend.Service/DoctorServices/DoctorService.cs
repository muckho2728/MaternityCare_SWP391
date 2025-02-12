using AutoMapper;
using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.DoctorServices.DTOs;
using MaternityCare_Backend.Service.IServices;

namespace MaternityCare_Backend.Service.DoctorServices
{
	internal sealed class DoctorService : IDoctorService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;

		public DoctorService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
		}

		private async Task<Doctor?> CheckDoctorExist(Guid doctorId, bool trackChange, CancellationToken ct = default)
		{
			var doctor = await repositoryManager.DoctorRepository.GetDoctor(doctorId, trackChange, ct);
			if (doctor is null) throw new DoctorNotFoundException();
			return doctor;
		}

		public async Task CreateDoctor(DoctorForCreationDto doctorForCreationDto, CancellationToken ct = default)
		{
			var doctorEntity = mapper.Map<Doctor>(doctorForCreationDto);
			if (doctorForCreationDto.Avatar is not null && doctorForCreationDto.Avatar.Length > 0)
			{
				await blobService.DeleteBlob(doctorEntity.Avatar.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(doctorForCreationDto.Avatar.FileName)}";
				doctorEntity.Avatar = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, doctorForCreationDto.Avatar);
			}
			doctorEntity.CreatedAt = DateTime.Now;
			doctorEntity.IsDeleted = false;
			repositoryManager.DoctorRepository.CreateDoctor(doctorEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteDoctor(Guid doctorId, bool trackChange, CancellationToken ct = default)
		{
			var doctorEntity = await CheckDoctorExist(doctorId, trackChange, ct);
			doctorEntity.IsDeleted = true;
			doctorEntity.DeletedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<DoctorForReturnDto> doctors, MetaData metaData)> GetDoctor(DoctorParameters doctorParameters, bool trackChange, CancellationToken ct = default)
		{
			var doctorWithMetaData = await repositoryManager.DoctorRepository.GetDoctors(doctorParameters, trackChange, ct);
			var doctors = mapper.Map<IEnumerable<DoctorForReturnDto>>(doctorWithMetaData);
			return (doctors, doctorWithMetaData.MetaData);
		}

		public async Task<DoctorForReturnDto> GetDoctorById(Guid doctorId, bool trackChange, CancellationToken ct = default)
		{
			var doctorEntity = await repositoryManager.DoctorRepository.GetDoctor(doctorId, trackChange, ct);
			return mapper.Map<DoctorForReturnDto>(doctorEntity);
		}

		public async Task UpdateDoctor(Guid doctorId, DoctorForUpdateDto doctorForUpdateDto, bool trackChange, CancellationToken ct = default)
		{
			var doctorEntity = await CheckDoctorExist(doctorId, trackChange, ct);
			mapper.Map(doctorForUpdateDto, doctorEntity);
			if (doctorForUpdateDto.Avatar is not null && doctorForUpdateDto.Avatar.Length > 0)
			{
				await blobService.DeleteBlob(doctorEntity.Avatar.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(doctorForUpdateDto.Avatar.FileName)}";
				doctorEntity.Avatar = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, doctorForUpdateDto.Avatar);
			}
			doctorEntity.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
