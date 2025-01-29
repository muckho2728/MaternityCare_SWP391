namespace MaternityCare_Backend.Service.AppointmentServices.DTOs
{
	public class AppointmentForReturnDto
	{
		public Guid Id { get; init; }
		public Guid UserId { get; init; }
		public Guid SlotId { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
