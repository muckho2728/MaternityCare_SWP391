namespace MaternityCare_Backend.Domain.Entities
{
	public class Reminder
	{
		public Guid Id { get; set; }
		public int Week { get; set; }
		public string Description { get; set; }
	}
}
