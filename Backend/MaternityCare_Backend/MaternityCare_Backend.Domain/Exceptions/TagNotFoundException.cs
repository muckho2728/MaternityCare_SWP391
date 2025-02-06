namespace MaternityCare_Backend.Domain.Exceptions
{
	public class TagNotFoundException : NotFoundException
	{
		public TagNotFoundException() : base("The tag does not exist!")
		{
		}
	}
}
