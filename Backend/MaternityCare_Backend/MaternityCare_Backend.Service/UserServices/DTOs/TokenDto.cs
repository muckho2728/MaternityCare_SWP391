﻿namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public record TokenDto
	{
		public string AccessToken { get; init; }
		public string RefreshToken { get; init; }
	}
}
