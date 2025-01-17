using MaternityCare_Backend.Domain.Constants;

namespace MaternityCare_Backend.Domain.Entities
{
	public class Subscription
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public Guid PackageId { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public SubscriptionStatus Status { get; set; }

		// Navigation properties
		public User User { get; set; }
		public Package Package { get; set; }
		public Transaction Transaction { get; set; }
	}
}
