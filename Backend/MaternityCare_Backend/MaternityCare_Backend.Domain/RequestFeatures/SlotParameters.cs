namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class SlotParameters : RequestParameters
	{
		public Guid DoctorId { get; init; }
		public DateOnly Date { get; init; }
	}
}
