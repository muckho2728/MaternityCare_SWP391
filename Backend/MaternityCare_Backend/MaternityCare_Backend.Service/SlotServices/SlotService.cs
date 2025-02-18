using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SlotServices.DTOs;
using Microsoft.AspNetCore.Mvc;
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

		private async Task<Slot> CheckSlotExist(Guid doctorId, Guid slotId, bool trackChange, CancellationToken ct = default)
		{
			var doctor = await repositoryManager.DoctorRepository.GetDoctor(doctorId, false, ct);
			if (doctor == null) throw new DoctorNotFoundException();
			var slot = await repositoryManager.SlotRepository.GetSlot(doctorId, slotId, trackChange, ct);
			if (slot == null) throw new SlotNotFoundException();
			return slot;
		}

		public async Task CreateSlot([FromRoute] Guid doctorId, SlotForCreationDto slotForCreationDto, CancellationToken ct = default)
		{
			var slotEntity = mapper.Map<Slot>(slotForCreationDto);
			var isOverlapped = await repositoryManager.SlotRepository.GetSlotsByDoctorId(slotEntity.DoctorId)
				.Where(s => s.Date == slotForCreationDto.Date && s.StartTime < slotForCreationDto.EndTime && s.EndTime > slotForCreationDto.StartTime)
				.AnyAsync();
			if (isOverlapped) throw new SlotConflictException("This slot is overlapped with another slot");
			slotEntity.IsBooked = false;
			slotEntity.DoctorId = doctorId;
			repositoryManager.SlotRepository.CreateSlot(slotEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteSlot(Guid doctorId, Guid slotId, bool trackChange, CancellationToken ct = default)
		{
			var slotEntity = await CheckSlotExist(doctorId, slotId, trackChange, ct);
			if (slotEntity.IsBooked) throw new SlotConflictException("This slot is already booked");
			repositoryManager.SlotRepository.DeleteSlot(slotEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<SlotForReturnDto?> GetSlot(Guid doctorId, Guid slotId, bool trackChange, CancellationToken ct = default)
		{
			var slotEntity = await CheckSlotExist(doctorId, slotId, trackChange, ct);
			return mapper.Map<SlotForReturnDto>(slotEntity);
		}

		public async Task<(IEnumerable<SlotForReturnDto> slots, MetaData metaData)> GetSlots(Guid doctorId, SlotParameters slotParameters, bool trackChange, CancellationToken ct = default)
		{
			var slotsWithMetaData = await repositoryManager.SlotRepository.GetSlots(doctorId, slotParameters, trackChange, ct);
			var slotsDto = mapper.Map<IEnumerable<SlotForReturnDto>>(slotsWithMetaData);
			return (slotsDto, slotsWithMetaData.MetaData);

		}
	}
}
