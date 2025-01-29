namespace MaternityCare_Backend.Service.SlotServices.DTOs
{
	public record SlotForReturnDto
	{
		public Guid Id { get; init; }
		public Guid DoctorId { get; init; }
		public DateOnly Date { get; init; }
		public TimeOnly StartTime { get; init; }
		public TimeOnly EndTime { get; init; }
		public bool IsBooked { get; init; }
	}
}
