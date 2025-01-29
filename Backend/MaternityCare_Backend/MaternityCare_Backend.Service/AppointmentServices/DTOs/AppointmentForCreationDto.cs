namespace MaternityCare_Backend.Service.AppointmentServices.DTOs
{
	public record AppointmentForCreationDto
	{
		public Guid UserId { get; init; }
		public Guid SlotId { get; init; }
	}
}
