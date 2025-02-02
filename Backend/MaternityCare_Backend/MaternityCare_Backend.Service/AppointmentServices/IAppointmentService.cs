using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.AppointmentServices.DTOs;

namespace MaternityCare_Backend.Service.AppointmentServices
{
	public interface IAppointmentService
	{
		Task CreateAppointment(AppointmentForCreationDto appointmentForCreationDto, CancellationToken ct = default);
		Task DeleteAppointment(Guid appointmentId, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<AppointmentForReturnDto> appointments, MetaData metaData)> GetAppointments(AppointmentParameters appointmentParameters, bool trackChange, CancellationToken ct = default);
		Task<AppointmentForReturnDto?> GetAppointment(Guid appointmentId, bool trackChange, CancellationToken ct = default);
		Task<byte[]> GenerateExcel(DateOnly date, CancellationToken ct = default);

	}
}
