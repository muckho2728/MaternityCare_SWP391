namespace MaternityCare_Backend.Domain.Entities
{
	public class Tag
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		// Navigation properties
		public ICollection<Blog> Blogs { get; set; }
	}
}
