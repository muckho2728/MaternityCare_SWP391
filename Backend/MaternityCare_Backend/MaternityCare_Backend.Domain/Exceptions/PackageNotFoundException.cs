namespace MaternityCare_Backend.Domain.Exceptions
{
	public class PackageNotFoundException : NotFoundException
	{
		public PackageNotFoundException() : base("The package does not exist")
		{
		}
	}
}
