using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IAppointmentRepository
	{
		void CreateAppointment(Appointment appointment);
		void DeleteAppointment(Appointment appointment);
		Task<Appointment?> GetAppointment(Guid userId, Guid slotId, bool trackChanges, CancellationToken ct = default);
		Task<PagedList<Appointment>> GetAppointments(Guid userId, AppointmentParameters appointmentParameters, bool trackChanges, CancellationToken ct = default);
		Task<IEnumerable<Appointment>> GetAppointmentsByDoctorIdAndDate(Guid doctorId, DateOnly date, bool trackChanges, CancellationToken ct = default);
	}
}
