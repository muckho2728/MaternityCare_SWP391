namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class UserParameters : RequestParameters
	{
		public string SearchName { get; set; } = string.Empty;
		public bool IsActive { get; set; } = true;
	}
}
