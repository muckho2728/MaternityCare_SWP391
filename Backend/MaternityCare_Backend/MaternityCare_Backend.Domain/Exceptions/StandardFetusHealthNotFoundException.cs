namespace MaternityCare_Backend.Domain.Exceptions
{
	public class StandardFetusHealthNotFoundException : NotFoundException
	{
		public StandardFetusHealthNotFoundException(int week) : base($"Standard health for week {week} does not exist!")
		{
		}
	}
}
