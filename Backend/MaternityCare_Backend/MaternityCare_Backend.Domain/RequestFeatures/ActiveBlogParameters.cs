namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class ActiveBlogParameters : RequestParameters
	{
		public string Title { get; set; } = string.Empty;
		public Guid TagId { get; set; } = Guid.Empty;
		public string SearchTitle { get; set; } = string.Empty;
	}
}
