namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class SubscriptionParameters : RequestParameters
	{
		public DateOnly StartDate { get; init; }
		public DateOnly EndDate { get; init; }
	}
}
