namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public record UserForAuthenticationDto
	{
		public string Username { get; init; }
		public string Password { get; init; }
	}
}
