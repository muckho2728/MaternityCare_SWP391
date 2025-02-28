using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.AIServices;
using Quartz;

namespace MaternityCare_Backend.Service.Jobs
{
	public class ValidateBlogsJob : IJob
	{
		private readonly IAIService aIService;
		private readonly IRepositoryManager repositoryManager;

		public ValidateBlogsJob(IAIService aIService, IRepositoryManager repositoryManager)
		{
			this.aIService = aIService;
			this.repositoryManager = repositoryManager;
		}
		public async Task Execute(IJobExecutionContext context)
		{
			var dataMap = context.MergedJobDataMap;
			Guid blogId = Guid.Parse(dataMap.GetString("blogId"));

			var blog = await repositoryManager.BlogRepository.GetBlog(blogId, true);

			if (await aIService.AnalyzeText(blog.Title) && await aIService.AnalyzeText(blog.Content) && await aIService.AnalyzeImage(blog.Image))
			{
				blog.IsActive = true;
				await repositoryManager.SaveAsync();
			}
		}
	}
}
