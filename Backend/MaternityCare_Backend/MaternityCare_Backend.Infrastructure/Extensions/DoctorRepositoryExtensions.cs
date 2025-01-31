using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class DoctorRepositoryExtensions
	{
		public static IQueryable<Doctor> Sort(this IQueryable<Doctor> doctors)
		{
			return doctors.OrderBy(d => d.FullName);
		}
	}
}
