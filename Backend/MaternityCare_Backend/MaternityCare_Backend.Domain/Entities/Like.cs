namespace MaternityCare_Backend.Domain.Entities
{
	public class Like
	{
		public Guid Id { get; set; }
		public Guid BlogId { get; set; }
		public Guid UserId { get; set; }
		public DateTime CreatedAt { get; set; }

		// Navigation properties
		public Blog Blog { get; set; }
		public User User { get; set; }
	}
}
