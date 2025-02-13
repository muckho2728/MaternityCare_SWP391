using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IBlogRepository
	{
		Task<PagedList<Blog>> GetBlogs(BlogParameters blogParameters, bool trackChanges, CancellationToken ct = default);
		Task<PagedList<Blog>> GetActiveBlogs(BlogParameters blogParameters, bool trackChanges, CancellationToken ct = default);
		Task<Blog?> GetBlog(Guid blogId, bool trackChanges, CancellationToken ct = default);
		void CreateBlog(Blog blog);
		void DeleteBlog(Blog blog);
	}
}
