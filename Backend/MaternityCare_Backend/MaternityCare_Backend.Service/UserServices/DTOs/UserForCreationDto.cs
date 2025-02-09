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
		[RegularExpression(@"^[A-Za-z][A-Za-z0-9]{5,}$", ErrorMessage = "Username must be at least 5 characters long, contain only letters and numbers and must start with a letter.")]
		public string Username { get; init; }
		[Required]
		public DateOnly DateOfBirth { get; init; }
		[Required]
		[RegularExpression(@"^\d{12}$", ErrorMessage = "Wrong format of CCCD.")]
		public string CCCD { get; init; }
		[Required]
		[RegularExpression(@"^[A-Za-z0-9]{5,}$", ErrorMessage = "Password must be at least 5 characters long and contain only letters and numbers.")]
		public string Password { get; init; }
		[Required]
		[Compare("Password")]
		public string ConfirmPassword { get; init; }
	}
}
