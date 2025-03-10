﻿using System.ComponentModel.DataAnnotations;

namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public record UserForResetPasswordDto
	{
		[Required]
		[EmailAddress]
		public string Email { get; init; }
		[Required]
		public string OTP { get; init; }
		[Required]
		public string Password { get; init; }
		[Required]
		[Compare("Password")]
		public string ConfirmPassword { get; init; }
	}
}
