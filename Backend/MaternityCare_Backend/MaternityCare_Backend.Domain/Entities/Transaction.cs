using MaternityCare_Backend.Domain.Constants;

namespace MaternityCare_Backend.Domain.Entities
{
	public class Transaction
	{
		public Guid Id { get; set; }
		public double Amount { get; set; }
		public string Description { get; set; }
		public DateTime CreatedAt { get; set; }
		public TransactionStatus Status { get; set; }
		public Guid SubscriptionId { get; set; }

		// Navigation properties
		public Subscription Subscription { get; set; }
	}
}
