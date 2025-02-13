namespace MaternityCare_Backend.Domain.Entities
{
	public class Blog
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string? Image { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public Guid UserId { get; set; }
		public Guid TagId { get; set; }

		// Navigation properties
		public User User { get; set; }
		public ICollection<Comment> Comments { get; set; }
		public ICollection<Like> Likes { get; set; }
		public Tag Tag { get; set; }
	}
}
