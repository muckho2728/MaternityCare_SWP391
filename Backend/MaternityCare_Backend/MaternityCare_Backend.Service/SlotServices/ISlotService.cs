using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SlotServices.DTOs;

namespace MaternityCare_Backend.Service.SlotServices
{
	public interface ISlotService
	{
		Task CreateSlot(SlotForCreationDto slotForCreationDto, CancellationToken ct = default);
		Task DeleteSlot(Guid slotId, CancellationToken ct = default);
		Task<SlotForReturnDto?> GetSlot(Guid slotId, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<SlotForReturnDto> slots, MetaData metaData)> GetSlots(SlotParameters slotParameters, bool trackChange, CancellationToken ct = default);
	}
}
