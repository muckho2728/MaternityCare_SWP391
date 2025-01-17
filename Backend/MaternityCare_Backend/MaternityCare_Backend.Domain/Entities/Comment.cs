namespace MaternityCare_Backend.Domain.Entities
{
	public class Comment
	{
		public Guid Id { get; set; }
		public string Content { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public Guid BlogId { get; set; }
		public Guid UserId { get; set; }

		//Navigation properties
		public Blog Blog { get; set; }
		public User User { get; set; }
	}
}
