namespace MaternityCare_Backend.Domain.Exceptions
{
	public class ReminderNotFoundException : NotFoundException
	{
		public ReminderNotFoundException(int week) : base($"Remidner for week {week} does not exist!")
		{
		}
	}
}
