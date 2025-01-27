using MaternityCare_Backend.Service.LikeServices.DTOs;

namespace MaternityCare_Backend.Service.LikeServices
{
	public interface ILikeService
	{
		Task CreateLike(LikeForCreationDto likeForCreationDto);
		Task DeleteLike(Guid blogId, Guid userId, bool trackChange);
		Task<IEnumerable<LikeForReturnDto>> GetLikesByBlogId(Guid blogId, bool trackChange);
	}
}
