using Azure;
using Azure.AI.ContentSafety;
using Azure.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MaternityCare_Backend.Service.AIServices
{
	public sealed class AIService : IAIService
	{
		private readonly IConfiguration configuration;
		private readonly ILogger<AIService> logger;
		private string endpoint;
		private string key;

		public AIService(IConfiguration configuration, ILogger<AIService> logger)
		{
			this.configuration = configuration;
			this.logger = logger;
			endpoint = configuration.GetSection("ContentSafetyEndpoint").Value;
			key = configuration.GetSection("ContentSafetyKey").Value;
		}

		public async Task AddOrUpdateBlockList(CancellationToken ct = default)
		{
			BlocklistClient blocklistClient = new BlocklistClient(new Uri(endpoint), new AzureKeyCredential(key));
			var blocklistName = "Vietnamese blocklist";
			var blocklistDescription = "This blocklist contains all the bad words in Vietnamese";

			var data = new
			{
				description = blocklistDescription,
			};

			await blocklistClient.CreateOrUpdateTextBlocklistAsync(blocklistName, RequestContent.Create(data));

			string blockListItemString = "giết;chết;địt;lồn;đụ;đéo;địt mẹ;địt con mẹ;địt con mẹ mày";
			var blocklistItems = new List<TextBlocklistItem>();
			foreach (var item in blockListItemString.Split(';'))
			{
				blocklistItems.Add(new TextBlocklistItem(item));
			}

			await blocklistClient.AddOrUpdateBlocklistItemsAsync(blocklistName, new AddOrUpdateTextBlocklistItemsOptions(blocklistItems));

		}

		public async Task<bool> AnalyzeImage(string? imageUrl, CancellationToken ct = default)
		{
			if (imageUrl == null) return true;
			ContentSafetyClient client = new ContentSafetyClient(new Uri(endpoint), new AzureKeyCredential(key));

			ContentSafetyImageData image = new ContentSafetyImageData(new Uri($@"{imageUrl}"));

			var request = new AnalyzeImageOptions(image);
			Response<AnalyzeImageResult> response = await client.AnalyzeImageAsync(request, ct);
			int hateSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Hate)?.Severity ?? 0;
			int selfHarmSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.SelfHarm)?.Severity ?? 0;
			int sexualSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Sexual)?.Severity ?? 0;
			int violenceSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Violence)?.Severity ?? 0;

			return hateSeverity == 0 && selfHarmSeverity == 0 && sexualSeverity == 0 && violenceSeverity == 0;
		}

		public async Task<bool> AnalyzeText(string text, CancellationToken ct = default)
		{
			ContentSafetyClient client = new ContentSafetyClient(new Uri(endpoint), new AzureKeyCredential(key));
			var blocklistName = "Vietnamese blocklist";

			var request = new AnalyzeTextOptions(text);
			request.BlocklistNames.Add(blocklistName);
			request.HaltOnBlocklistHit = true;


			Response<AnalyzeTextResult> response = await client.AnalyzeTextAsync(request, ct);
			int hateSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Hate)?.Severity ?? 0;
			int selfHarmSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.SelfHarm)?.Severity ?? 0;
			int sexualSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Sexual)?.Severity ?? 0;
			int violenceSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Violence)?.Severity ?? 0;

			return hateSeverity == 0 && selfHarmSeverity == 0 && sexualSeverity == 0 && violenceSeverity == 0;
		}
	}
}
