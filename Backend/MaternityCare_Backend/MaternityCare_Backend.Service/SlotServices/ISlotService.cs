using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SlotServices.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.Service.SlotServices
{
	public interface ISlotService
	{
		Task CreateSlot([FromRoute] Guid doctorId, SlotForCreationDto slotForCreationDto, CancellationToken ct = default);
		Task DeleteSlot(Guid doctorId, Guid slotId, bool trackChange, CancellationToken ct = default);
		Task<SlotForReturnDto?> GetSlot(Guid doctorId, Guid slotId, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<SlotForReturnDto> slots, MetaData metaData)> GetSlots(Guid doctorId, SlotParameters slotParameters, bool trackChange, CancellationToken ct = default);
	}
}
