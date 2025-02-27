using Microsoft.AspNetCore.Http;

namespace MaternityCare_Backend.Service.BlogServices.DTOs
{
	public record BlogForCreationDto
	{
		public string Title { get; init; }
		public string Content { get; init; }
		public IFormFile? Image { get; init; }
		public Guid TagId { get; init; }
	}
}
