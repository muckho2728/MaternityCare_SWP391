namespace MaternityCare_Backend.Service.LikeServices.DTOs
{
	public record LikeForReturnDto
	{
		public Guid Id { get; init; }
		public Guid BlogId { get; init; }
		public Guid UserId { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
