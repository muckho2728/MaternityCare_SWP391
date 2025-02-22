using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.DoctorServices.DTOs;

namespace MaternityCare_Backend.Service.DoctorServices
{
	public interface IDoctorService
	{
		Task<(IEnumerable<DoctorForReturnDto> doctors, MetaData metaData)> GetDoctor(DoctorParameters doctorParameters, CancellationToken ct = default);
		Task<DoctorForReturnDto> GetDoctorById(Guid doctorId, CancellationToken ct = default);
		Task CreateDoctor(DoctorForCreationDto doctorForCreationDto, CancellationToken ct = default);
		Task UpdateDoctor(Guid doctorId, DoctorForUpdateDto doctorForUpdateDto, CancellationToken ct = default);
		Task DeleteDoctor(Guid doctorId, CancellationToken ct = default);
	}
}
