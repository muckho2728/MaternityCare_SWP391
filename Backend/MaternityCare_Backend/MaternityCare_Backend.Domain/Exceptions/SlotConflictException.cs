namespace MaternityCare_Backend.Domain.Exceptions
{
	public class SlotConflictException : ConflictException
	{
		public SlotConflictException(string? message) : base(message)
		{
		}
	}
}
