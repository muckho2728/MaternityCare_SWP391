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

		public Task<Slot?> GetSlot(Guid doctorId, Guid slotId, bool trackChange, CancellationToken ct = default) => FindByCondition(s => s.Id.Equals(slotId) && s.DoctorId.Equals(doctorId), trackChange).SingleOrDefaultAsync(ct);

		public Task<Slot?> GetSlot(Guid slotId, bool trackChange, CancellationToken ct = default) => FindByCondition(s => s.Id.Equals(slotId), trackChange).SingleOrDefaultAsync(ct);


		public async Task<PagedList<Slot>> GetSlots(Guid doctorId, SlotParameters slotParameters, bool trackChange, CancellationToken ct = default)
		{
			var slotEntities = FindByCondition(s => s.DoctorId.Equals(doctorId), trackChange)
				.Filter(slotParameters.Date)
				.Sort();
			return await PagedList<Slot>.ToPagedList(slotEntities, slotParameters.PageNumber, slotParameters.PageSize, ct);
		}

		public IQueryable<Slot> GetSlotsByDoctorId(Guid doctorId) => FindByCondition(s => s.DoctorId.Equals(doctorId), false);
	}
}
