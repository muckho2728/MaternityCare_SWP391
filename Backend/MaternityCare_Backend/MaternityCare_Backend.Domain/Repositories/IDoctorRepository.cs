using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IDoctorRepository
	{
		Task<PagedList<Doctor>> GetDoctors(DoctorParameters doctorParameters, bool trackChange);
		Task<IEnumerable<Doctor>> GetDoctors(bool trackChange);
	}
}
