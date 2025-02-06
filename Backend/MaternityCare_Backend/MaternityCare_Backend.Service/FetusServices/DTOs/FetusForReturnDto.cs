namespace MaternityCare_Backend.Service.FetusServices.DTOs
{
	public record FetusForReturnDto
	{
		public Guid Id { get; init; }
		public Guid UserId { get; init; }
		public DateOnly DueDate { get; init; }
		public DateOnly ConceptionDate { get; init; }
		public DateTime CreatedAt { get; init; }
		public DateTime? UpdatedAt { get; init; }
	}
}
