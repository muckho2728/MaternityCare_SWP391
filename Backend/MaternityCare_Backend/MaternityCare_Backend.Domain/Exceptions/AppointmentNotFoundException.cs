namespace MaternityCare_Backend.Domain.Exceptions
{
	public class AppointmentNotFoundException : NotFoundException
	{
		public AppointmentNotFoundException() : base("The appointment does not exist")
		{
		}
	}
}
