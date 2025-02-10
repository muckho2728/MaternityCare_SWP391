using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IDoctorRepository
	{
		Task<PagedList<Doctor>> GetDoctors(DoctorParameters doctorParameters, bool trackChange, CancellationToken ct = default);
		Task<IEnumerable<Doctor>> GetDoctors(bool trackChange, CancellationToken ct = default);
		Task<Doctor?> GetDoctor(Guid doctorId, bool trackChange, CancellationToken ct = default);
		void CreateDoctor(Doctor doctor);
	}
}
