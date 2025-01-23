using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public record UserForUpdateDto
	{
		[Required]
		public string FullName { get; init; }
		[Required]
		public DateOnly DateOfBirth { get; init; }
		public IFormFile? Avatar { get; init; }
	}
}
