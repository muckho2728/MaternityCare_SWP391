namespace MaternityCare_Backend.Domain.Entities
{
	public class StandardFetusHealth
	{
		public Guid Id { get; set; }
		public int Week { get; set; }
		public double HeadCircumference { get; set; }
		public double AmnioticFluidLevel { get; set; }
		public double CrownRumpLength { get; set; }
		public double BiparietalDiameter { get; set; }
		public double FemurLength { get; set; }
		public double EstimatedFetalWeight { get; set; }
		public double AbdominalCircumference { get; set; }
		public double GestationalSacDiameter { get; set; }
	}
}
