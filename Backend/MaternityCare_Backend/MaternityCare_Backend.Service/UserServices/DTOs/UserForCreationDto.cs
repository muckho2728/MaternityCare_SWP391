using System.ComponentModel.DataAnnotations;

namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public record UserForCreationDto
	{
		[Required]
		public string FullName { get; init; }
		[EmailAddress]
		[Required]
		public string Email { get; init; }
		[Required]
		public string Username { get; init; }
		[Required]
		public DateOnly DateOfBirth { get; init; }
		[Required]
		public string CCCD { get; init; }
		[Required]
		public string Password { get; init; }
		[Required]
		[Compare("Password")]
		public string ConfirmPassword { get; init; }
	}
}
