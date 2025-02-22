using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.BlogServices.DTOs;

namespace MaternityCare_Backend.Service.BlogServices
{
	internal sealed class BlogService : IBlogService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public BlogService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		private async Task<Blog?> CheckBlogExist(Guid blogId, bool trackChange, CancellationToken ct)
		{
			var blog = await repositoryManager.BlogRepository.GetBlog(blogId, trackChange, ct);
			if (blog is null) throw new BlogNotFoundException();
			return blog;
		}
		public async Task ActivateBlog(Guid blogId, CancellationToken ct = default)
		{
			var blogEntity = await CheckBlogExist(blogId, true, ct);
			blogEntity.IsActive = !blogEntity.IsActive;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreateBlog(BlogForCreationDto blogForCreationDto, CancellationToken ct = default)
		{
			var blogEntity = mapper.Map<Blog>(blogForCreationDto);
			blogEntity.IsActive = false;
			blogEntity.CreatedAt = DateTime.Now;
			repositoryManager.BlogRepository.CreateBlog(blogEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteBlog(Guid blogId, CancellationToken ct = default)
		{
			var blogEntity = await CheckBlogExist(blogId, false, ct);
			repositoryManager.BlogRepository.DeleteBlog(blogEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetActiveBlogs(BlogParameters blogParameters, CancellationToken ct = default)
		{
			var blogsWithMetaData = await repositoryManager.BlogRepository.GetActiveBlogs(blogParameters, false, ct);
			var blogs = mapper.Map<IEnumerable<BlogForReturnDto>>(blogsWithMetaData);
			return (blogs, blogsWithMetaData.MetaData);
		}

		public async Task<BlogForReturnDto> GetBlog(Guid blogId, CancellationToken ct = default)
		{
			var blogEntity = await CheckBlogExist(blogId, false, ct);
			return mapper.Map<BlogForReturnDto>(blogEntity);
		}

		public async Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetBlogs(BlogParameters blogParameters, CancellationToken ct = default)
		{
			var blogsWithMetaData = await repositoryManager.BlogRepository.GetBlogs(blogParameters, false, ct);
			var blogs = mapper.Map<IEnumerable<BlogForReturnDto>>(blogsWithMetaData);
			return (blogs, blogsWithMetaData.MetaData);
		}

		public async Task UpdateBlog(Guid blogId, BlogForUpdateDto blogForUpdateDto, CancellationToken ct = default)
		{
			var blogEntity = await CheckBlogExist(blogId, true, ct);
			mapper.Map(blogForUpdateDto, blogEntity);
			blogEntity.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
