using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IAppointmentRepository
	{
		void CreateAppointment(Appointment appointment);
		void DeleteAppointment(Appointment appointment);
		Task<Appointment?> GetAppointment(Guid appointmentId, bool trackChanges);
		Task<PagedList<Appointment>> GetAppointments(AppointmentParameters appointmentParameters, bool trackChanges);
		Task<IEnumerable<Appointment>> GetAppointmentsByDoctorIdAndDate(Guid doctorId, DateOnly date, bool trackChanges);
	}
}
