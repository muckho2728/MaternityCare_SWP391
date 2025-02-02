using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
	{
		public AppointmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateAppointment(Appointment appointment) => Create(appointment);

		public void DeleteAppointment(Appointment appointment) => Delete(appointment);

		public async Task<Appointment?> GetAppointment(Guid appointmentId, bool trackChanges, CancellationToken ct = default) => await FindByCondition(a => a.Id.Equals(appointmentId), trackChanges).Include(a => a.Slot).SingleOrDefaultAsync(ct);

		public async Task<PagedList<Appointment>> GetAppointments(AppointmentParameters appointmentParameters, bool trackChanges, CancellationToken ct = default)
		{
			var appointmentEntities = FindAll(trackChanges)
				.Sort()
				.Include(a => a.Slot);
			return await PagedList<Appointment>.ToPagedList(appointmentEntities, appointmentParameters.PageNumber, appointmentParameters.PageSize, ct);
		}

		public async Task<IEnumerable<Appointment>> GetAppointmentsByDoctorIdAndDate(Guid doctorId, DateOnly date, bool trackChanges, CancellationToken ct = default) => await FindAll(trackChanges)
			.AsSplitQuery().Include(a => a.Slot).Where(a => a.Slot.DoctorId.Equals(doctorId) && a.Slot.Date == date)
			.AsSplitQuery().Include(a => a.User)
			.ToListAsync(ct);
	}
}
