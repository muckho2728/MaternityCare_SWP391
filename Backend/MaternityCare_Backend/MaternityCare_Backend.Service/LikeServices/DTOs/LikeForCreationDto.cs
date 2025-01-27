namespace MaternityCare_Backend.Service.LikeServices.DTOs
{
	public record LikeForCreationDto
	{
		public Guid BlogId { get; init; }
		public Guid UserId { get; init; }
	}
}
