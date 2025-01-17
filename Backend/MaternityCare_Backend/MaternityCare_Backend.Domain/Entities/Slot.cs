namespace MaternityCare_Backend.Domain.Entities
{
	public class Slot
	{
		public Guid Id { get; set; }
		public Guid DoctorId { get; set; }
		public DateOnly Date { get; set; }
		public TimeOnly StartTime { get; set; }
		public TimeOnly EndTime { get; set; }
		public bool IsActive { get; set; }
		public bool IsBooked { get; set; }

		// Navigation properties
		public Doctor Doctor { get; set; }
		public Appointment Appointment { get; set; }
	}
}
