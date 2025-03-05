using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
	{
		public DoctorRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateDoctor(Doctor doctor) => Create(doctor);

		public async Task<PagedList<Doctor>> GetActiveDoctors(DoctorParameters doctorParameters, bool trackChange, CancellationToken ct = default)
		{
			var doctors = FindByCondition(d => d.IsDeleted == false, trackChange)
				.Sort();
			return await PagedList<Doctor>.ToPagedList(doctors, doctorParameters.PageNumber, doctorParameters.PageSize, ct);
		}

		public Task<Doctor?> GetDoctor(Guid doctorId, bool trackChange, CancellationToken ct = default) => FindByCondition(d => d.Id.Equals(doctorId), trackChange).SingleOrDefaultAsync(ct);

		public async Task<PagedList<Doctor>> GetDoctors(DoctorParameters doctorParameters, bool trackChange, CancellationToken ct = default)
		{
			var doctors = FindAll(trackChange)
				.Sort();
			return await PagedList<Doctor>.ToPagedList(doctors, doctorParameters.PageNumber, doctorParameters.PageSize, ct);
		}

		public async Task<IEnumerable<Doctor>> GetDoctors(bool trackChange, CancellationToken ct = default) => await FindAll(trackChange).ToListAsync(ct);
	}
}
