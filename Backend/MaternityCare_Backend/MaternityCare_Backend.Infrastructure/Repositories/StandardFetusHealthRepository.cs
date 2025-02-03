using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class StandardFetusHealthRepository : RepositoryBase<StandardFetusHealth>, IStandardFetusHealthRepository
	{
		public StandardFetusHealthRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public async Task<StandardFetusHealth?> GetStandardFetusHealth(int week, bool trackChange, CancellationToken ct) => await FindByCondition(standardFetusHealth => standardFetusHealth.Week == week, trackChange).SingleOrDefaultAsync(ct);

		public async Task<IEnumerable<StandardFetusHealth>> GetStandardFetusHealths(bool trackChange, CancellationToken ct) => await FindAll(trackChange).OrderBy(s => s.Week).ToListAsync(ct);
	}
}
