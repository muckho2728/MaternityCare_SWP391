using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SlotServices.DTOs;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Service.SlotServices
{
	internal sealed class SlotService : ISlotService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public SlotService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		private async Task<Slot> CheckSlotExist(Guid slotId, bool trackChange, CancellationToken ct = default)
		{
			var slot = await repositoryManager.SlotRepository.GetSlot(slotId, trackChange, ct);
			if (slot == null) throw new SlotNotFoundException();
			return slot;
		}

		public async Task CreateSlot(SlotForCreationDto slotForCreationDto, CancellationToken ct = default)
		{
			var slotEntity = mapper.Map<Slot>(slotForCreationDto);
			var isOverlapped = await repositoryManager.SlotRepository.GetSlotsByDoctorId(slotEntity.DoctorId)
				.Where(s => s.Date == slotForCreationDto.Date && s.StartTime < slotForCreationDto.EndTime && s.EndTime > slotForCreationDto.StartTime)
				.AnyAsync();
			if (isOverlapped) throw new SlotConflictException("This slot is overlapped with another slot");
			slotEntity.IsBooked = false;
			repositoryManager.SlotRepository.CreateSlot(slotEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteSlot(Guid slotId, CancellationToken ct = default)
		{
			var slotEntity = await CheckSlotExist(slotId, false, ct);
			if (slotEntity.IsBooked) throw new SlotConflictException("This slot is already booked");
			repositoryManager.SlotRepository.DeleteSlot(slotEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<SlotForReturnDto?> GetSlot(Guid slotId, bool trackChange, CancellationToken ct = default)
		{
			var slotEntity = await CheckSlotExist(slotId, false, ct);
			return mapper.Map<SlotForReturnDto>(slotEntity);
		}

		public async Task<(IEnumerable<SlotForReturnDto> slots, MetaData metaData)> GetSlots(SlotParameters slotParameters, bool trackChange, CancellationToken ct = default)
		{
			var slotsWithMetaData = await repositoryManager.SlotRepository.GetSlots(slotParameters, trackChange, ct);
			var slotsDto = mapper.Map<IEnumerable<SlotForReturnDto>>(slotsWithMetaData);
			return (slotsDto, slotsWithMetaData.MetaData);

		}
	}
}
