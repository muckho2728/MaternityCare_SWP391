using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
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
			var fetusHealthy = await repositoryManager.FetusHealthRepository.GetFetusHealthByFetusIdAndWeek(fetusId, fetusHealthForCreationDto.Week, false, ct);
			if (fetusHealthy != null) throw new FetusHealthConflictException("Fetus health already exists for this week");
			var fetusHealthEntity = mapper.Map<FetusHealth>(fetusHealthForCreationDto);
			fetusHealthEntity.FetusId = fetusId;
			repositoryManager.FetusHealthRepository.CreateFetusHealth(fetusHealthEntity);
			var standardFetusHealthEntity = await repositoryManager.StandardFetusHealthRepository.GetStandardFetusHealth(fetusHealthForCreationDto.Week, false, ct);
			var reminderEntity = await repositoryManager.ReminderRepository.GetReminderNextWeek(fetusHealthForCreationDto.Week, false, ct);
			await repositoryManager.SaveAsync(ct);
			return (mapper.Map<FetusHealthForReturnDto>(fetusHealthEntity), mapper.Map<StandardFetusHealthForReturnDto>(standardFetusHealthEntity), mapper.Map<ReminderForReturnDto>(reminderEntity));
		}

		public async Task<(IEnumerable<FetusHealthForReturnDto> fetusHealths, MetaData metaData)> GetFetusHealthByFetusId(FetusHealthParameters fetusHealthParameters, Guid fetusId, CancellationToken ct = default)
		{
			var fetusHealthWithMetaData = await repositoryManager.FetusHealthRepository.GetFetusHealthByFetusId(fetusHealthParameters, fetusId, false, ct);
			var fetusHealthDto = mapper.Map<IEnumerable<FetusHealthForReturnDto>>(fetusHealthWithMetaData);
			return (fetusHealthDto, fetusHealthWithMetaData.MetaData);
		}

		public async Task<(FetusHealthForReturnDto fetusHealth, StandardFetusHealthForReturnDto standardFetusHealth, ReminderForReturnDto reminder)> GetFetusHealthByFetusIdAndWeek(Guid fetusId, int week, CancellationToken ct = default)
		{
			var fetusHealthEntity = await repositoryManager.FetusHealthRepository.GetFetusHealthByFetusIdAndWeek(fetusId, week, false, ct);
			var standardFetusHealthEntity = await repositoryManager.StandardFetusHealthRepository.GetStandardFetusHealth(week, false, ct);
			var reminderEntity = await repositoryManager.ReminderRepository.GetReminderNextWeek(week, false, ct);
			return (mapper.Map<FetusHealthForReturnDto>(fetusHealthEntity), mapper.Map<StandardFetusHealthForReturnDto>(standardFetusHealthEntity), mapper.Map<ReminderForReturnDto>(reminderEntity));
		}

		public async Task UpdateFetusHealth(Guid fetusId, int week, FetusHealthForUpdateDto fetusHealthForUpdateDto, CancellationToken ct = default)
		{
			var fetusHealthEntity = await repositoryManager.FetusHealthRepository.GetFetusHealthByFetusIdAndWeek(fetusId, week, true, ct);
			mapper.Map(fetusHealthForUpdateDto, fetusHealthEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
