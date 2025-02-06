using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class FetusRepository : RepositoryBase<Fetus>, IFetusRepository
	{
		public FetusRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateFetus(Fetus fetus) => Create(fetus);

		public async Task<PagedList<Fetus>> GetFetusByUserId(FetusParameters fetusParameters, Guid userId, bool trackChange, CancellationToken ct = default)
		{
			var fetusEntities = FindByCondition(f => f.UserId.Equals(userId), trackChange)
				.Sort();

			return await PagedList<Fetus>.ToPagedList(fetusEntities, fetusParameters.PageNumber, fetusParameters.PageSize, ct);
		}
	}
}
