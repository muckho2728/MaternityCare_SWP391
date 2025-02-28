namespace MaternityCare_Backend.Service.FetusHealthServices.DTOs
{
	public record FetusHealthForUpdateDto
	{
		public double? HeadCircumference { get; init; }
		public double? AmnioticFluidLevel { get; init; }
		public double? CrownRumpLength { get; init; }
		public double? BiparietalDiameter { get; init; }
		public double? FemurLength { get; init; }
		public double? EstimatedFetalWeight { get; init; }
		public double? AbdominalCircumference { get; init; }
		public double? GestationalSacDiameter { get; init; }
	}
}
