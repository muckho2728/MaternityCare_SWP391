using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class LikeRepository : RepositoryBase<Like>, ILikeRepository
	{
		public LikeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateLike(Like like) => Create(like);

		public void DeleteLike(Like like) => Delete(like);

		public async Task<Like?> GetLikeByBlogIdAndUserId(Guid blogId, Guid userId, bool trackChange) => await FindByCondition(l => l.BlogId == blogId && l.UserId == userId, trackChange).SingleOrDefaultAsync();

		public async Task<IEnumerable<Like>> GetLikesByBlogId(Guid blogId, bool trackChange) => await FindByCondition(l => l.BlogId == blogId, trackChange).ToListAsync();
	}

}
