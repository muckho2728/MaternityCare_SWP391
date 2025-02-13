using MaternityCare_Backend.Service.TagServices.DTOs;

namespace MaternityCare_Backend.Service.BlogServices.DTOs
{
	public record BlogForReturnDto
	{
		public Guid Id { get; init; }
		public string Title { get; init; }
		public string Content { get; init; }
		public string? Image { get; init; }
		public bool IsActive { get; init; }
		public TagForReturnDto Tag { get; init; }
	}
}
