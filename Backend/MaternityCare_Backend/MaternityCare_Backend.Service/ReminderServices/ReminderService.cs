using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.ReminderServices.DTOs;

namespace MaternityCare_Backend.Service.ReminderServices
{
	internal sealed class ReminderService : IReminderService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public ReminderService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task<ReminderForReturnDto?> GetReminder(int week, bool trackChange, CancellationToken ct)
		{
			var reminderEntity = await repositoryManager.ReminderRepository.GetReminder(week, trackChange, ct);
			return mapper.Map<ReminderForReturnDto>(reminderEntity);
		}

		public async Task<IEnumerable<ReminderForReturnDto>> GetReminders(bool trackChange, CancellationToken ct)
		{
			var reminderEntities = await repositoryManager.ReminderRepository.GetReminders(trackChange, ct);
			return mapper.Map<IEnumerable<ReminderForReturnDto>>(reminderEntities);
		}
	}
}
