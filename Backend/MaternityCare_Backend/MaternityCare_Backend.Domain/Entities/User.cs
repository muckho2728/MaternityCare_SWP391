namespace MaternityCare_Backend.Domain.Entities
{
	public class User
	{
		public Guid Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string DateOfBirth { get; set; }
		public string Avatar { get; set; }
		public bool IsEmailConfirmed { get; set; }
		public Guid RoleId { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime? UpdatedAt { get; set; }

		//Navigation properties
		public ICollection<Blog> Blogs { get; set; }
		public ICollection<Comment> Comments { get; set; }
		public ICollection<Like> Likes { get; set; }
		public ICollection<Feedback> Feedbacks { get; set; }
		public Role Role { get; set; }
		public ICollection<Fetus> Fetus { get; set; }
		public ICollection<Appointment> Appointments { get; set; }
		public ICollection<Subscription> Subscriptions { get; set; }
		public ICollection<Transaction> Transactions { get; set; }
	}
}
