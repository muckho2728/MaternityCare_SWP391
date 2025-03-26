namespace MaternityCare_Backend.Service.AIServices
{
	public interface IAIService
	{
		Task<bool> AnalyzeText(string text, CancellationToken ct = default);
		Task<bool> AnalyzeImage(string image, CancellationToken ct = default);
		Task AddOrUpdateBlockList(CancellationToken ct = default);
	}
}
