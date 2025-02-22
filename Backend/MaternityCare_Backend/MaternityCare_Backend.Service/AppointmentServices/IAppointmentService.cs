using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.AppointmentServices.DTOs;

namespace MaternityCare_Backend.Service.AppointmentServices
{
	public interface IAppointmentService
	{
		Task CreateAppointment(Guid userId, Guid slotId, CancellationToken ct = default);
		Task DeleteAppointment(Guid userId, Guid slotId, CancellationToken ct = default);
		Task<(IEnumerable<AppointmentForReturnDto> appointments, MetaData metaData)> GetAppointments(Guid userId, AppointmentParameters appointmentParameters, CancellationToken ct = default);
		Task<AppointmentForReturnDto?> GetAppointment(Guid userId, Guid slotId, CancellationToken ct = default);
		Task<byte[]> GenerateExcel(DateOnly date, CancellationToken ct = default);

	}
}
