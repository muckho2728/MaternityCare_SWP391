namespace MaternityCare_Backend.Domain.Entities
{
	public class Fetus
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public DateOnly DueDate { get; set; }
		public DateOnly ConceptionDate { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }

		// Navigation properties
		public User User { get; set; }
		public ICollection<FetusHealth> FetusHealths { get; set; }
	}
}
