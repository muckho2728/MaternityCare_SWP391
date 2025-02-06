using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class FetusHealthRepository : RepositoryBase<FetusHealth>, IFetusHealthRepository
	{
		public FetusHealthRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateFetusHealth(FetusHealth fetusHealth) => Create(fetusHealth);

		public async Task<PagedList<FetusHealth>> GetFetusHealthByFetusId(FetusHealthParameters fetusHealthParameters, Guid fetusId, bool trackChange, CancellationToken ct = default)
		{
			var fetusHealthEntities = FindByCondition(f => f.FetusId.Equals(fetusId), trackChange)
				.Sort();

			return await PagedList<FetusHealth>.ToPagedList(fetusHealthEntities, fetusHealthParameters.PageNumber, fetusHealthParameters.PageSize, ct);
		}
	}
}
