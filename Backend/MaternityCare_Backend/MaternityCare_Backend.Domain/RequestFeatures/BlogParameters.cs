namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class BlogParameters : RequestParameters
	{
		public string Title { get; set; } = string.Empty;
		public Guid TagId { get; set; } = Guid.Empty;
		public bool IsActive { get; set; } = true;
		public string SearchTitle { get; set; } = string.Empty;
	}
}
