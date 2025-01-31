namespace MaternityCare_Backend.Domain.Entities
{
	public class StandardFetusHealth
	{
		public Guid Id { get; set; }
		public int Week { get; set; }
		public string? HeadCircumference { get; set; }
		public string? AmnioticFluidLevel { get; set; }
		public string? CrownRumpLength { get; set; }
		public string? BiparietalDiameter { get; set; }
		public string? FemurLength { get; set; }
		public string? EstimatedFetalWeight { get; set; }
		public string? AbdominalCircumference { get; set; }
		public string? GestationalSacDiameter { get; set; }
	}
}
