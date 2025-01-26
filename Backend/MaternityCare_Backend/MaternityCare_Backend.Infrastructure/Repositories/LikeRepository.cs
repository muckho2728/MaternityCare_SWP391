using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	public class LikeRepository : RepositoryBase<Like>, ILikeRepository
	{
		public LikeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}
	}

}
