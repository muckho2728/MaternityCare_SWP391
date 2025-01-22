namespace MaternityCare_Backend.Domain.Entities
{
	public class User
	{
		public Guid Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public DateOnly DateOfBirth { get; set; }
		public string Avatar { get; set; }
		public string CCCD { get; set; }
		public Guid RoleId { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public bool IsEmailConfirmed { get; set; }
		public string? EmailConfirmationToken { get; set; }
		public string? PasswordResetToken { get; set; }
		public DateTime? PasswordResetTokenExpiryTime { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenExpiryTime { get; set; }

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
