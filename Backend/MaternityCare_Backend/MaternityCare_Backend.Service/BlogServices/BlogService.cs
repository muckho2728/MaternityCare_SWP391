using AutoMapper;
using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.BlogServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.Jobs;
using Quartz;

namespace MaternityCare_Backend.Service.BlogServices
{
	internal sealed class BlogService : IBlogService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly ISchedulerFactory schedulerFactory;
		private readonly IBlobService blobService;

		public BlogService(IRepositoryManager repositoryManager, IMapper mapper, ISchedulerFactory schedulerFactory, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.schedulerFactory = schedulerFactory;
			this.blobService = blobService;
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

		public async Task CreateBlog(Guid userId, BlogForCreationDto blogForCreationDto, CancellationToken ct = default)
		{
			var blogEntity = mapper.Map<Blog>(blogForCreationDto);
			blogEntity.IsActive = false;
			blogEntity.CreatedAt = DateTime.Now;
			blogEntity.UserId = userId;
			if (blogForCreationDto.Image is not null && blogForCreationDto.Image.Length > 0)
			{
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(blogForCreationDto.Image.FileName)}";
				blogEntity.Image = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, blogForCreationDto.Image);
			}
			repositoryManager.BlogRepository.CreateBlog(blogEntity);
			await repositoryManager.SaveAsync(ct);

			IJobDetail job = JobBuilder.Create<ValidateBlogsJob>()
				.WithIdentity("validateBlogJob", "BlogGroup")
				.UsingJobData("blogId", blogEntity.Id.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("validateBlogTrigger", "BlogGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}

		public async Task DeleteBlog(Guid userId, Guid blogId, CancellationToken ct = default)
		{
			var blogEntity = await CheckBlogExist(blogId, false, ct);
			if (blogEntity.UserId != userId) throw new BlogConflictException("You cannot delete other people blogs");
			repositoryManager.BlogRepository.DeleteBlog(blogEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetActiveBlogs(ActiveBlogParameters activeBlogParameters, CancellationToken ct = default)
		{
			var blogsWithMetaData = await repositoryManager.BlogRepository.GetActiveBlogs(activeBlogParameters, false, ct);
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

		public async Task UpdateBlog(Guid userId, Guid blogId, BlogForUpdateDto blogForUpdateDto, CancellationToken ct = default)
		{
			var blogEntity = await CheckBlogExist(blogId, true, ct);
			if (blogEntity.UserId != userId) throw new BlogConflictException("You cannot modify other people blogs");
			mapper.Map(blogForUpdateDto, blogEntity);
			blogEntity.IsActive = false;
			blogEntity.UpdatedAt = DateTime.Now;
			if (blogForUpdateDto.Image is not null && blogForUpdateDto.Image.Length > 0)
			{
				await blobService.DeleteBlob(blogEntity.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(blogForUpdateDto.Image.FileName)}";
				blogEntity.Image = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, blogForUpdateDto.Image);
			}
			await repositoryManager.SaveAsync(ct);

			IJobDetail job = JobBuilder.Create<ValidateBlogsJob>()
				.WithIdentity("validateBlogJob", "BlogGroup")
				.UsingJobData("blogId", blogEntity.Id.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("validateBlogTrigger", "BlogGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}

		public async Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetBlogsByUserId(BlogParameters blogParameters, Guid userId, CancellationToken ct = default)
		{
			var blogsWithMetaData = await repositoryManager.BlogRepository.GetBlogsByUserId(blogParameters, userId, false, ct);
			var blogs = mapper.Map<IEnumerable<BlogForReturnDto>>(blogsWithMetaData);
			return (blogs, blogsWithMetaData.MetaData);
		}
	}
}
