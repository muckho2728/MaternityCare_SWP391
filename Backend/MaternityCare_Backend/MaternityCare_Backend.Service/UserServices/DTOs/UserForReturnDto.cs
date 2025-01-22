using MaternityCare_Backend.Service.RoleServices.DTOs;

namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public record UserForReturnDto
	{
		public Guid Id { get; init; }
		public string FullName { get; init; }
		public string Email { get; init; }
		public string Username { get; init; }
		public DateOnly DateOfBirth { get; init; }
		public string Avatar { get; init; }
		public string CCCD { get; init; }
		public bool IsActive { get; init; }
		public RoleForReturnDto Role { get; set; }
	}
}
