namespace MaternityCare_Backend.Domain.Exceptions
{
	public class FetusNotFoundException : NotFoundException
	{
		public FetusNotFoundException() : base("The fetus does not exist!")
		{
		}
	}
}
