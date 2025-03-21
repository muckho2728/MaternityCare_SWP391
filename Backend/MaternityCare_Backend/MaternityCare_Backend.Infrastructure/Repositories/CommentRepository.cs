using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class CommentRepository : RepositoryBase<Comment>, ICommentRepository
	{
		public CommentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateComment(Comment comment) => Create(comment);

		public void DeleteComment(Comment comment) => Delete(comment);

		public async Task<Comment?> GetComment(Guid commentId, bool trackChange, CancellationToken ct) => await FindByCondition(c => c.Id == commentId, trackChange).Include(c => c.User).SingleOrDefaultAsync(ct);

		public async Task<PagedList<Comment>> GetCommentsByBlogId(CommentParameters commentParameters, Guid blogId, bool trackChange, CancellationToken ct = default)
		{
			var commentEntities = FindByCondition(c => c.BlogId == blogId, false)
				.Include(c => c.User)
				.Sort();

			return await PagedList<Comment>.ToPagedList(commentEntities, commentParameters.PageNumber, commentParameters.PageSize, ct);
		}
	}
}
