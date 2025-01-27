namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class SubscriptionParameters : RequestParameters
	{
		public DateOnly StartDate { get; set; } = DateOnly.MinValue;
		public DateOnly EndDate { get; set; } = DateOnly.MaxValue;
	}
}
