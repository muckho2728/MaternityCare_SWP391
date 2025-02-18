namespace MaternityCare_Backend.Service.SlotServices.DTOs
{
	public record SlotForCreationDto
	{
		public DateOnly Date { get; init; }
		public TimeOnly StartTime { get; init; }
		public TimeOnly EndTime { get; init; }
	}
}
