namespace MaternityCare_Backend.Service.FetusServices.DTOs
{
	public record FetusForUpdateDto
	{
		public DateOnly DueDate { get; init; }
		public DateOnly ConceptionDate { get; init; }
	}
}
