using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class TagRepository : RepositoryBase<Tag>, ITagRepository
	{
		public TagRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public async Task<Tag?> GetTag(Guid tagId, bool trackChange, CancellationToken ct = default) => await FindByCondition(tag => tag.Id == tagId, trackChange).SingleOrDefaultAsync();

		public async Task<IEnumerable<Tag>> GetTags(bool trackChange, CancellationToken ct = default) => await FindAll(trackChange).ToListAsync();
	}
}
