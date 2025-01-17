namespace MaternityCare_Backend.Domain.Entities
{
	public class Appointment
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public Guid SlotId { get; set; }
		public DateTime CreatedAt { get; set; }

		// Navigation properties
		public User User { get; set; }
		public Slot Slot { get; set; }
	}
}
