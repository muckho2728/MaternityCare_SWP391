using Microsoft.AspNetCore.SignalR;

namespace MaternityCare_Backend.Service.SignalRServices
{
	public class NotificationHub : Hub
	{
		public override Task OnConnectedAsync()
		{
			return base.OnConnectedAsync();
		}

		public override Task OnDisconnectedAsync(Exception? exception)
		{
			return base.OnDisconnectedAsync(exception);
		}
	}
}
