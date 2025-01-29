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

		private async Task<Slot> CheckSlotExist(Guid slotId, bool trackChange)
		{
			var slot = await repositoryManager.SlotRepository.GetSlot(slotId, trackChange);
			if (slot == null) throw new SlotNotFoundException();
			return slot;
		}

		public async Task CreateSlot(SlotForCreationDto slotForCreationDto)
		{
			var slotEntity = mapper.Map<Slot>(slotForCreationDto);
			var isOverlapped = await repositoryManager.SlotRepository.GetSlotsByDoctorId(slotEntity.DoctorId)
				.Where(s => s.StartTime < slotForCreationDto.EndTime && s.EndTime > slotForCreationDto.StartTime)
				.AnyAsync();
			if (isOverlapped) throw new SlotConflictException("This slot is overlapped with another slot");
			slotEntity.IsBooked = false;
			repositoryManager.SlotRepository.CreateSlot(slotEntity);
			await repositoryManager.SaveAsync();
		}

		public async Task DeleteSlot(Guid slotId)
		{
			var slotEntity = await CheckSlotExist(slotId, false);
			if (slotEntity.IsBooked) throw new SlotConflictException("This slot is already booked");
			repositoryManager.SlotRepository.DeleteSlot(slotEntity);
			await repositoryManager.SaveAsync();
		}

		public async Task<SlotForReturnDto?> GetSlot(Guid slotId, bool trackChange)
		{
			var slotEntity = await CheckSlotExist(slotId, false);
			return mapper.Map<SlotForReturnDto>(slotEntity);
		}

		public async Task<(IEnumerable<SlotForReturnDto> slots, MetaData metaData)> GetSlots(SlotParameters slotParameters, bool trackChange)
		{
			var slotsWithMetaData = await repositoryManager.SlotRepository.GetSlots(slotParameters, trackChange);
			var slotsDto = mapper.Map<IEnumerable<SlotForReturnDto>>(slotsWithMetaData);
			return (slotsDto, slotsWithMetaData.MetaData);

		}
	}
}
