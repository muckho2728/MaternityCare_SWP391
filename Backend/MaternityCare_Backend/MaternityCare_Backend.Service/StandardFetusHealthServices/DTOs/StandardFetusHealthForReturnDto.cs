namespace MaternityCare_Backend.Service.StandardFetusHealthServices.DTOs
{
	public record StandardFetusHealthForReturnDto
	{
		public Guid Id { get; init; }
		public int Week { get; init; }
		public string? HeadCircumference { get; init; }
		public string? AmnioticFluidLevel { get; init; }
		public string? CrownRumpLength { get; init; }
		public string? BiparietalDiameter { get; init; }
		public string? FemurLength { get; init; }
		public string? EstimatedFetalWeight { get; init; }
		public string? AbdominalCircumference { get; init; }
		public string? GestationalSacDiameter { get; init; }
	}
}
