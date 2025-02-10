using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ITagRepository
	{
		Task<IEnumerable<Tag>> GetTags(bool trackChange, CancellationToken ct = default);
		Task<Tag?> GetTag(Guid tagId, bool trackChange, CancellationToken ct = default);
	}
}
