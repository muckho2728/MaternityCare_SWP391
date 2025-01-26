namespace MaternityCare_Backend.Service.SubscriptionServices.DTOs
{
	public record SubscriptionForCreationDto
	{
		public Guid UserId { get; init; }
		public Guid PackageId { get; init; }
	}
}
