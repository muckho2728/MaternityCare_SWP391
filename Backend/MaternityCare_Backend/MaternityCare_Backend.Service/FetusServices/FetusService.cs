using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusServices.DTOs;

namespace MaternityCare_Backend.Service.FetusServices
{
	internal sealed class FetusService : IFetusService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public FetusService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task CreateFetus(Guid userId, FetusForCreationDto fetusForCreationDto, CancellationToken ct)
		{
			var fetusEntity = mapper.Map<Fetus>(fetusForCreationDto);
			fetusEntity.UserId = userId;
			fetusEntity.DueDate = fetusEntity.ConceptionDate.AddMonths(9).AddDays(10);
			fetusEntity.CreatedAt = DateTime.Now;
			repositoryManager.FetusRepository.CreateFetus(fetusEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<FetusForReturnDto> fetuses, MetaData metaData)> GetFetusesByUserId(FetusParameters fetusParameters, Guid userId, bool trackChange, CancellationToken ct = default)
		{
			var fetusWithMetaData = await repositoryManager.FetusRepository.GetFetusesByUserId(fetusParameters, userId, trackChange, ct);
			var fetusesDto = mapper.Map<IEnumerable<FetusForReturnDto>>(fetusWithMetaData);
			return (fetusesDto, fetusWithMetaData.MetaData);
		}

		public async Task UpdateFetus(Guid fetusId, FetusForUpdateDto fetusForUpdateDto, bool trackChange, CancellationToken ct)
		{
			var fetusEntity = await repositoryManager.FetusRepository.GetFetusById(fetusId, trackChange, ct);
			if (fetusEntity is null) throw new FetusNotFoundException();
			mapper.Map(fetusForUpdateDto, fetusEntity);
			fetusEntity.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
