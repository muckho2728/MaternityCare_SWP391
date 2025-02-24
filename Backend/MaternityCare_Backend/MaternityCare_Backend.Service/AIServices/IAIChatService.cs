using OpenAI.Chat;

namespace MaternityCare_Backend.Service.AIServices
{
	public interface IAIChatService
	{
		Task<ChatCompletion> Asking(string message);
	}
}
