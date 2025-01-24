using System.ComponentModel.DataAnnotations;

namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public record UserForUpdatePasswordDto
	{
		[Required]
		public string CurrentPassword { get; init; }
		[Required]
		public string NewPassword { get; init; }
		[Required]
		[Compare("NewPassword")]
		public string ConfirmPassword { get; init; }
	}
}
