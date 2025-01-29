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

		public async Task<Appointment?> GetAppointment(Guid appointmentId, bool trackChanges) => await FindByCondition(a => a.Id.Equals(appointmentId), trackChanges).Include(a => a.Slot).SingleOrDefaultAsync();

		public async Task<PagedList<Appointment>> GetAppointments(AppointmentParameters appointmentParameters, bool trackChanges)
		{
			var appointmentEntities = FindAll(trackChanges)
				.Sort()
				.Include(a => a.Slot);
			return await PagedList<Appointment>.ToPagedList(appointmentEntities, appointmentParameters.PageNumber, appointmentParameters.PageSize);
		}
	}
}
