using MaternityCare_Backend.Service.SlotServices.DTOs;
using MaternityCare_Backend.Service.UserServices.DTOs;

namespace MaternityCare_Backend.Service.AppointmentServices.DTOs
{
	public class AppointmentForReturnDto
	{
		public Guid Id { get; init; }
		public Guid UserId { get; init; }
		public UserForReturnDto User { get; init; }
		public Guid SlotId { get; init; }
		public SlotForReturnDto Slot { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
