using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusHealthServices.DTOs;
using MaternityCare_Backend.Service.ReminderServices.DTOs;
using MaternityCare_Backend.Service.StandardFetusHealthServices.DTOs;

namespace MaternityCare_Backend.Service.FetusHealthServices
{
	internal sealed class FetusHealthService : IFetusHealthService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public FetusHealthService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task<(FetusHealthForReturnDto fetusHealth, StandardFetusHealthForReturnDto standardFetusHealth, ReminderForReturnDto reminder)> CreateFetusHealth(Guid fetusId, FetusHealthForCreationDto fetusHealthForCreationDto, CancellationToken ct = default)
		{
			var fetusHealthEntity = mapper.Map<FetusHealth>(fetusHealthForCreationDto);
			fetusHealthEntity.FetusId = fetusId;
			repositoryManager.FetusHealthRepository.CreateFetusHealth(fetusHealthEntity);
			var standardFetusHealthEntity = await repositoryManager.StandardFetusHealthRepository.GetStandardFetusHealth(fetusHealthForCreationDto.Week, false, ct);
			var reminderEntity = await repositoryManager.ReminderRepository.GetReminderNextWeek(fetusHealthForCreationDto.Week, false, ct);
			await repositoryManager.SaveAsync(ct);
			return (mapper.Map<FetusHealthForReturnDto>(fetusHealthEntity), mapper.Map<StandardFetusHealthForReturnDto>(standardFetusHealthEntity), mapper.Map<ReminderForReturnDto>(reminderEntity));
		}

		public async Task<(IEnumerable<FetusHealthForReturnDto> fetusHealths, MetaData metaData)> GetFetusHealthByFetusId(FetusHealthParameters fetusHealthParameters, Guid fetusId, bool trackChange, CancellationToken ct = default)
		{
			var fetusHealthWithMetaData = await repositoryManager.FetusHealthRepository.GetFetusHealthByFetusId(fetusHealthParameters, fetusId, trackChange, ct);
			var fetusHealthDto = mapper.Map<IEnumerable<FetusHealthForReturnDto>>(fetusHealthWithMetaData);
			return (fetusHealthDto, fetusHealthWithMetaData.MetaData);
		}
	}
}
