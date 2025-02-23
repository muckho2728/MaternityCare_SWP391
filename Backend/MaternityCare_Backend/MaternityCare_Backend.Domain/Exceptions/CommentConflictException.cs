namespace MaternityCare_Backend.Domain.Exceptions
{
	public class CommentConflictException : ConflictException
	{
		public CommentConflictException(string? message) : base(message)
		{
		}
	}
}
