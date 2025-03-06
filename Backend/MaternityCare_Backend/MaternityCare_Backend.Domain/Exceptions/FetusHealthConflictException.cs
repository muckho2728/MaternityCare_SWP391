namespace MaternityCare_Backend.Domain.Exceptions
{
	public class FetusHealthConflictException : ConflictException
	{
		public FetusHealthConflictException(string? message) : base(message)
		{
		}
	}
}
