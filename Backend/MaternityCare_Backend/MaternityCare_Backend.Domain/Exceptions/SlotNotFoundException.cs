namespace MaternityCare_Backend.Domain.Exceptions
{
	public class SlotNotFoundException : NotFoundException
	{
		public SlotNotFoundException() : base("This slot does not exist")
		{
		}
	}
}
