using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.StandardFetusHealthServices.DTOs;

namespace MaternityCare_Backend.Service.StandardFetusHealthServices
{
	internal sealed class StandardFetusHealthService : IStandardFetusHealthService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public StandardFetusHealthService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task<StandardFetusHealthForReturnDto?> GetStandardFetusHealth(int week, bool trackChange, CancellationToken ct)
		{
			var standardFetusHealthEntity = await repositoryManager.StandardFetusHealthRepository.GetStandardFetusHealth(week, trackChange, ct);
			return mapper.Map<StandardFetusHealthForReturnDto>(standardFetusHealthEntity);
		}

		public async Task<IEnumerable<StandardFetusHealthForReturnDto>> GetStandardFetusHealths(bool trackChange, CancellationToken ct)
		{
			var standardFetusHealthEntities = await repositoryManager.StandardFetusHealthRepository.GetStandardFetusHealths(trackChange, ct);
			return mapper.Map<IEnumerable<StandardFetusHealthForReturnDto>>(standardFetusHealthEntities);
		}
	}
}
