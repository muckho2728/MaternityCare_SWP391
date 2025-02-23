using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ICommentRepository
	{
		void CreateComment(Comment comment);
		void DeleteComment(Comment comment);
		Task<PagedList<Comment>> GetCommentsByBlogId(CommentParameters commentParameters, Guid blogId, bool trackChange, CancellationToken ct = default);
		Task<Comment?> GetComment(Guid commentId, bool trackChange, CancellationToken ct);
	}
}
