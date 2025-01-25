namespace MaternityCare_Backend.Service.PackageServices.DTOs
{
	public record PackageForReturnDto
	{
		public Guid Id { get; init; }
		public string Type { get; init; }
		public string Feature { get; init; }
		public double Price { get; init; }
		public double Duration { get; init; }
	}
}
