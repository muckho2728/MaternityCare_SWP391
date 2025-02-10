namespace MaternityCare_Backend.Service.TagServices.DTOs
{
	public record TagForReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
	}
}
