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
		public async Task Execute(IJobExecutionContext context)
		{
			var appointments = await repositoryManager.AppointmentRepository.GetAppointmentsAfterToday(false);
			foreach (var appointment in appointments)
			{
				await hubContext.Clients.User(appointment.User.Id.ToString()).SendAsync("ReceiveNotification", $"You have an appointment on {appointment.Slot.Date} at {appointment.Slot.StartTime}");
			}
		}
	}
}
