using MaternityCare_Backend.Domain.Constants;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IRoleRepository
	{
		public Task<Guid> GetIdByRoleName(Roles roleName, bool trackChange);
	}
}
