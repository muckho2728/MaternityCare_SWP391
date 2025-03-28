﻿using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;

namespace MaternityCare_Backend.Service.TransactionServices.DTOs
{
	public record TransactionForReturnDto
	{
		public Guid Id { get; init; }
		public double Amount { get; init; }
		public string Description { get; init; }
		public DateTime CreatedAt { get; init; }
		public TransactionStatus Status { get; init; }
		public Guid SubscriptionId { get; init; }
		public SubscriptionForReturnDto Subscription { get; init; }
	}
}
