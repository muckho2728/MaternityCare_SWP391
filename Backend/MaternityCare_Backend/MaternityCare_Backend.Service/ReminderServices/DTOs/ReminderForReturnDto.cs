namespace MaternityCare_Backend.Service.ReminderServices.DTOs
{
	public record ReminderForReturnDto
	{
		public Guid Id { get; init; }
		public int Week { get; init; }
		public string Description { get; init; }
	}
}
