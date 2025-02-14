namespace MaternityCare_Backend.Service.FetusServices.DTOs
{
	public record FetusForCreationDto
	{
		public DateOnly ConceptionDate { get; init; }
	}
}
