namespace MaternityCare_Backend.Domain.Exceptions
{
	public class SubscriptionNotFoundException : NotFoundException
	{
		public SubscriptionNotFoundException() : base("The subscription does not exist")
		{
		}
	}
}
