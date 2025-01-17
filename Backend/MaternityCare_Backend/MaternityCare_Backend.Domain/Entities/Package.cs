namespace MaternityCare_Backend.Domain.Entities
{
	public class Package
	{
		public Guid Id { get; set; }
		public string Type { get; set; }
		public string Feature { get; set; }
		public double Price { get; set; }
		public double Duration { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }

		// Navigation properties
		public ICollection<Subscription> Subscriptions { get; set; }
	}
}
