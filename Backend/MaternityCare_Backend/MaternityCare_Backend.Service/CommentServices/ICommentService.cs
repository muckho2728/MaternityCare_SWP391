using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.CommentServices.DTOs;

namespace MaternityCare_Backend.Service.CommentServices
{
	public interface ICommentService
	{
		Task CreateComment(Guid blogId, Guid userId, CommentForCreationDto commentForCreationDto, CancellationToken ct = default);
		Task DeleteComment(Guid commentId, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<CommentForReturnDto> comments, MetaData metaData)> GetCommentsByBlogId(CommentParameters commentParameters, Guid blogId, bool trackChange, CancellationToken ct = default);
		Task UpdateComment(Guid commentId, CommentForUpdateDto commentForUpdateDto, bool trackChange, CancellationToken ct = default);
	}
}
