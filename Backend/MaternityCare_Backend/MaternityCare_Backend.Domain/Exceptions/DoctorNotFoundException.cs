namespace MaternityCare_Backend.Domain.Exceptions
{
	public class DoctorNotFoundException : NotFoundException
	{
		public DoctorNotFoundException() : base("The doctor does not exist.")
		{
		}
	}
}
