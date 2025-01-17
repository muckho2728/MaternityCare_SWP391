namespace MaternityCare_Backend.Domain.Entities
{
	public class Tag
	{
		public int Id { get; set; }
		public string Name { get; set; }

		// Navigation properties
		public ICollection<Blog> Blogs { get; set; }
	}
}
