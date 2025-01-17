namespace MaternityCare_Backend.Domain.Entities
{
	public class Feedback
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public double Score { get; set; }
		public string Content { get; set; }
		public DateTime CreatedAt { get; set; }

		// Navigation properties
		public User User { get; set; }
	}
}
