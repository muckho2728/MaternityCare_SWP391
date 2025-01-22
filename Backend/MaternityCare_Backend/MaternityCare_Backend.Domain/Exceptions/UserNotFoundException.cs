namespace MaternityCare_Backend.Domain.Exceptions
{
	public sealed class UserNotFoundException : NotFoundException
	{
		public UserNotFoundException() : base($"The user doesn't exist")
		{
		}
	}
}
