using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace MaternityCare_Backend.Service.SignalRServices
{
	public class NotificationHub : Hub
	{
		public override Task OnConnectedAsync()
		{
			string userId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			Clients.All.SendAsync("ReceiveMessage", $"A new user with id {userId} has joined the chat");
			return base.OnConnectedAsync();
		}
	}
}
