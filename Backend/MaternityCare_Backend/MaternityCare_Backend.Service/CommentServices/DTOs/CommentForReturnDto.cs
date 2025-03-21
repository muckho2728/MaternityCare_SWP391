using MaternityCare_Backend.Service.UserServices.DTOs;

namespace MaternityCare_Backend.Service.CommentServices.DTOs
{
	public record CommentForReturnDto
	{
		public Guid Id { get; init; }
		public string Content { get; init; }
		public DateTime CreatedAt { get; init; }
		public DateTime? UpdatedAt { get; init; }
		public Guid BlogId { get; init; }
		public Guid UserId { get; init; }
		public UserForReturnDto User { get; init; }
	}
}
