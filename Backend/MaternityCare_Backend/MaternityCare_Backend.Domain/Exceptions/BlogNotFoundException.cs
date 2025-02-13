namespace MaternityCare_Backend.Domain.Exceptions
{
	public class BlogNotFoundException : NotFoundException
	{
		public BlogNotFoundException() : base("The blog does not exist")
		{
		}
	}
}
