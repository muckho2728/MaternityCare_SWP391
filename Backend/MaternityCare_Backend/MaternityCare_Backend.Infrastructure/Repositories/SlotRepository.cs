using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class SlotRepository : RepositoryBase<Slot>, ISlotRepository
	{
		public SlotRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateSlot(Slot slot) => Create(slot);

		public void DeleteSlot(Slot slot) => Delete(slot);

		public Task<Slot?> GetSlot(Guid slotId, bool trackChange) => FindByCondition(s => s.Id.Equals(slotId), trackChange).SingleOrDefaultAsync();

		public async Task<PagedList<Slot>> GetSlots(SlotParameters slotParameters, bool trackChange)
		{
			var slotEntities = FindAll(trackChange)
				.Filter(slotParameters.DoctorId, slotParameters.Date)
				.Sort();
			return await PagedList<Slot>.ToPagedList(slotEntities, slotParameters.PageNumber, slotParameters.PageSize);
		}

		public IQueryable<Slot> GetSlotsByDoctorId(Guid doctorId) => FindByCondition(s => s.DoctorId.Equals(doctorId), false);
	}
}
