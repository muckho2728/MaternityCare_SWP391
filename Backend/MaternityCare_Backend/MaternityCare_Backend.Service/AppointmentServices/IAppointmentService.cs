using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.AppointmentServices.DTOs;

namespace MaternityCare_Backend.Service.AppointmentServices
{
	public interface IAppointmentService
	{
		Task CreateAppointment(AppointmentForCreationDto appointmentForCreationDto);
		Task DeleteAppointment(Guid appointmentId, bool trackChange);
		Task<(IEnumerable<AppointmentForReturnDto> appointments, MetaData metaData)> GetAppointments(AppointmentParameters appointmentParameters, bool trackChange);
		Task<AppointmentForReturnDto?> GetAppointment(Guid appointmentId, bool trackChange);

	}
}
