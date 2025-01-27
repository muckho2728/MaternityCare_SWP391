using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ILikeRepository
	{
		void CreateLike(Like like);
		void DeleteLike(Like like);
		Task<IEnumerable<Like>> GetLikesByBlogId(Guid blogId, bool trackChange);
		Task<Like?> GetLikeByBlogIdAndUserId(Guid blogId, Guid userId, bool trackChange);
	}
}
