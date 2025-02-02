using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
	{
		public UserRepository(RepositoryContext context) : base(context)
		{
		}
		public void CreateUser(User user) => Create(user);

		public async Task<PagedList<User>> GetUsers(UserParameters userParameters, bool trackChange, CancellationToken ct = default)
		{
			var userEntities = FindByCondition(u => u.Role.Name != Roles.Admin.ToString(), trackChange)
				.Filter(userParameters.IsActive)
				.Search(userParameters.SearchName)
				.Sort()
				.Include(u => u.Role);

			return await PagedList<User>.ToPagedList(userEntities, userParameters.PageNumber, userParameters.PageSize, ct);
		}

		public async Task<User?> GetUserByCccd(string cccd, bool trackChange, CancellationToken ct = default) => await FindByCondition(u => u.CCCD == cccd, trackChange).Include(u => u.Role).SingleOrDefaultAsync(ct);

		public async Task<User?> GetUserByEmail(string email, bool trackChange, CancellationToken ct = default) => await FindByCondition(u => u.Email == email, trackChange).Include(u => u.Role).SingleOrDefaultAsync(ct);

		public async Task<User?> GetUserById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(u => u.Id == id, trackChange).Include(u => u.Role).SingleOrDefaultAsync(ct);

		public async Task<User?> GetUserByUserName(string userName, bool trackChange, CancellationToken ct = default) => await FindByCondition(u => u.Username == userName, trackChange).Include(u => u.Role).SingleOrDefaultAsync(ct);

		public Task<User?> GetUserByUsernameAndPassword(string username, string password, bool trackChange, CancellationToken ct = default) => FindByCondition(u => u.Username == username && u.Password == password, trackChange).SingleOrDefaultAsync(ct);
	}
}
