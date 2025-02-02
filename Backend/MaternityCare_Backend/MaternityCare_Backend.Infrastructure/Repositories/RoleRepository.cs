using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class RoleRepository : RepositoryBase<Role>, IRoleRepository
	{
		public RoleRepository(RepositoryContext context) : base(context)
		{
		}
		public async Task<Guid> GetIdByRoleName(Roles roleName, bool trackChange, CancellationToken ct = default) => await FindByCondition(r => r.Name == roleName.ToString(), trackChange).Select(r => r.Id).SingleOrDefaultAsync(ct);
	}
}
