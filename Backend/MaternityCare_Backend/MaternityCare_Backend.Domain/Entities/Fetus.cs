using MaternityCare_Backend.Domain.Constants;

namespace MaternityCare_Backend.Domain.Entities
{
	public class Fetus
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public DateOnly DueDate { get; set; }
		public DateOnly ConceptionDate { get; set; }
		public BloodType BloodType { get; set; }
		public bool IsActive { get; set; }

		// Navigation properties
		public User User { get; set; }
		public ICollection<FetusHealth> FetusHealths { get; set; }
	}
}
