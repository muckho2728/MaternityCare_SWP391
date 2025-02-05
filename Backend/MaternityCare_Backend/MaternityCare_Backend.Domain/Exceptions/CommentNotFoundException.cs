namespace MaternityCare_Backend.Domain.Exceptions
{
	public class CommentNotFoundException : NotFoundException
	{
		public CommentNotFoundException() : base("The comment not found")
		{
		}
	}
}
