using Microsoft.Extensions.Configuration;
using OpenAI.Chat;

namespace MaternityCare_Backend.Service.AIServices
{
	internal sealed class AIChatService : IAIChatService
	{
		private readonly IConfiguration configuration;

		public AIChatService(IConfiguration configuration)
		{
			this.configuration = configuration;
		}
		public async Task<ChatCompletion> Asking(string message)
		{
			ChatClient chatClient = new(model: "gpt-4o-mini", apiKey: configuration.GetSection("OpenAIKey").Value);
			var completion = await chatClient.CompleteChatAsync(message);
			return completion.Value;
		}
	}
}
