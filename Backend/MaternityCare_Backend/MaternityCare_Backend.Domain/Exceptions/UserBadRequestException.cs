namespace MaternityCare_Backend.Domain.Exceptions
{
	public class UserBadRequestException : BadRequestException
	{
		public UserBadRequestException(string? message) : base(message)
		{
		}
	}
}
