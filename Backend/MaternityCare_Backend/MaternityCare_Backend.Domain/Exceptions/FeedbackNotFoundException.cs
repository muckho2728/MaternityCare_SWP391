namespace MaternityCare_Backend.Domain.Exceptions
{
	public class FeedbackNotFoundException : NotFoundException
	{
		public FeedbackNotFoundException() : base($"The feedback doesn't exist")
		{
		}
	}
}
