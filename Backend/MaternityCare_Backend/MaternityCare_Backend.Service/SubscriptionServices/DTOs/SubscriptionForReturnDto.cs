namespace MaternityCare_Backend.Service.SubscriptionServices.DTOs
{
	public record SubscriptionForReturnDto
	{
		public Guid Id { get; init; }
		public Guid UserId { get; init; }
		public Guid PackageId { get; init; }
		public DateOnly? StartDate { get; init; }
		public DateOnly? EndDate { get; init; }
	}
}
