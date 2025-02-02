using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.DoctorServices.DTOs;

namespace MaternityCare_Backend.Service.DoctorServices
{
	public interface IDoctorService
	{
		Task<(IEnumerable<DoctorForReturnDto> doctors, MetaData metaData)> GetDoctor(DoctorParameters doctorParameters, bool trackChange, CancellationToken ct = default);
	}
}
