using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.DoctorServices.DTOs;

namespace MaternityCare_Backend.Service.DoctorServices
{
	internal sealed class DoctorService : IDoctorService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public DoctorService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task<(IEnumerable<DoctorForReturnDto> doctors, MetaData metaData)> GetDoctor(DoctorParameters doctorParameters, bool trackChange)
		{
			var doctorWithMetaData = await repositoryManager.DoctorRepository.GetDoctors(doctorParameters, trackChange);
			var doctors = mapper.Map<IEnumerable<DoctorForReturnDto>>(doctorWithMetaData);
			return (doctors, doctorWithMetaData.MetaData);
		}
	}
}
