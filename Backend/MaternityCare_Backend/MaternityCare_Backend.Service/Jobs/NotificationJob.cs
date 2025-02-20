using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.SignalRServices;
using Microsoft.AspNetCore.SignalR;
using Quartz;

namespace MaternityCare_Backend.Service.Jobs
{
	public class NotificationJob : IJob
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IHubContext<NotificationHub> hubContext;

		public NotificationJob(IRepositoryManager repositoryManager, IHubContext<NotificationHub> hubContext)
		{
			this.repositoryManager = repositoryManager;
			this.hubContext = hubContext;
		}
		public Task Execute(IJobExecutionContext context)
		{

			return Task.CompletedTask;
		}
	}
}
