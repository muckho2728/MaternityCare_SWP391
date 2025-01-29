namespace MaternityCare_Backend.Domain.Exceptions
{
	public class AppointmentConflictException : ConflictException
	{
		public AppointmentConflictException(string? message) : base(message)
		{
		}
	}
}
