using MaternityCare_Backend.Service.LikeServices.DTOs;

namespace MaternityCare_Backend.Service.LikeServices
{
	public interface ILikeService
	{
		Task CreateLike(Guid blogId, Guid userId, CancellationToken ct = default);
		Task DeleteLike(Guid blogId, Guid userId, bool trackChange, CancellationToken ct = default);
		Task<IEnumerable<LikeForReturnDto>> GetLikesByBlogId(Guid blogId, bool trackChange, CancellationToken ct = default);
		Task<int> GetNumberOfLikesByBlogId(Guid blogId, bool trackChange, CancellationToken ct = default);
	}
}
