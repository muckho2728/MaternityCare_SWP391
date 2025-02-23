namespace MaternityCare_Backend.Domain.Exceptions
{
	public class BlogConflictException : ConflictException
	{
		public BlogConflictException(string? message) : base(message)
		{
		}
	}
}
