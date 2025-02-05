namespace MaternityCare_Backend.Service.CommentServices.DTOs
{
	public record CommentForCreationDto
	{
		public string Content { get; init; }
		public Guid BlogId { get; init; }
		public Guid UserId { get; init; }
	}
}
