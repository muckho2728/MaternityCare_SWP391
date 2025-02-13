using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class BlogRepository : RepositoryBase<Blog>, IBlogRepository
	{
		public BlogRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateBlog(Blog blog) => Create(blog);

		public void DeleteBlog(Blog blog) => Delete(blog);

		public async Task<PagedList<Blog>> GetActiveBlogs(BlogParameters blogParameters, bool trackChanges, CancellationToken ct = default)
		{
			var blogEntities = FindByCondition(b => b.IsActive, trackChanges)
				.Filter(blogParameters.TagId, blogParameters.IsActive)
				.Search(blogParameters.Title)
				.Sort()
				.Include(b => b.Tag);

			return await PagedList<Blog>.ToPagedList(blogEntities, blogParameters.PageNumber, blogParameters.PageSize, ct);
		}

		public async Task<Blog?> GetBlog(Guid blogId, bool trackChanges, CancellationToken ct = default) => await FindByCondition(b => b.Id == blogId, trackChanges).Include(b => b.Tag).SingleOrDefaultAsync(ct);

		public async Task<PagedList<Blog>> GetBlogs(BlogParameters blogParameters, bool trackChanges, CancellationToken ct = default)
		{
			var blogEntities = FindAll(trackChanges)
				.Filter(blogParameters.TagId, blogParameters.IsActive)
				.Search(blogParameters.Title)
				.Sort()
				.Include(b => b.Tag);

			return await PagedList<Blog>.ToPagedList(blogEntities, blogParameters.PageNumber, blogParameters.PageSize, ct);
		}
	}
}
