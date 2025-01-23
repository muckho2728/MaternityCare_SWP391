namespace MaternityCare_Backend.Service.FeedbackServices.DTOs
{
	public record FeedbackForCreationDto
	{
		public Guid UserId { get; init; }
		public double Score { get; init; }
		public string Content { get; init; }
	}
}
