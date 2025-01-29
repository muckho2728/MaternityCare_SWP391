using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ISlotRepository
	{
		void CreateSlot(Slot slot);
		void DeleteSlot(Slot slot);
		Task<PagedList<Slot>> GetSlots(SlotParameters slotParameters, bool trackChange);
		Task<Slot?> GetSlot(Guid slotId, bool trackChange);
	}
}
