namespace MaternityCare_Backend.Service.FetusServices.DTOs
{
	public record FetusForCreationDto
	{
		public Guid UserId { get; init; }
		public DateOnly ConceptionDate { get; init; }
	}
}
