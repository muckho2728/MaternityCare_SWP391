using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ISlotRepository
	{
		void CreateSlot(Slot slot);
		void DeleteSlot(Slot slot);
		Task<PagedList<Slot>> GetSlots(Guid doctorId, SlotParameters slotParameters, bool trackChange, CancellationToken ct = default);
		IQueryable<Slot> GetSlotsByDoctorId(Guid doctorId);
		Task<Slot?> GetSlot(Guid doctorId, Guid slotId, bool trackChange, CancellationToken ct = default);
		Task<Slot?> GetSlot(Guid slotId, bool trackChange, CancellationToken ct = default);
	}
}
