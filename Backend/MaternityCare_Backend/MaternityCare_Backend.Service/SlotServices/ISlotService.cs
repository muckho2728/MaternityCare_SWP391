using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SlotServices.DTOs;

namespace MaternityCare_Backend.Service.SlotServices
{
	public interface ISlotService
	{
		Task CreateSlot(SlotForCreationDto slotForCreationDto);
		Task DeleteSlot(Guid slotId);
		Task<SlotForReturnDto?> GetSlot(Guid slotId, bool trackChange);
		Task<(IEnumerable<SlotForReturnDto> slots, MetaData metaData)> GetSlots(SlotParameters slotParameters, bool trackChange);
	}
}
