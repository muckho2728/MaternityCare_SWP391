﻿using MaternityCare_Backend.Service.UserServices.DTOs;

namespace MaternityCare_Backend.Service.FeedbackServices.DTOs
{
	public record FeedbackForReturnDto
	{
		public Guid Id { get; init; }
		public Guid UserId { get; init; }
		public double Score { get; init; }
		public string Content { get; init; }
		public UserForReturnDto User { get; init; }
	}
}
