using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	public class UserRepository : RepositoryBase<User>, IUserRepository
	{
		public UserRepository(RepositoryContext context) : base(context)
		{
		}
		public void CreateUser(User user) => Create(user);

		public async Task<PagedList<User>> GetUsers(UserParameters userParameters, bool trackChange)
		{
			var userEntities = await FindByCondition(u => u.Role.Name != Roles.Admin.ToString(), trackChange)
				.Where(u => u.IsActive == userParameters.IsActive)
				.Skip((userParameters.PageNumber - 1) * userParameters.PageSize)
				.Take(userParameters.PageSize)
				.Include(u => u.Role)
				.ToListAsync();

			var count = await FindByCondition(u => u.Role.Name != Roles.Admin.ToString(), trackChange)
				.Where(u => u.IsActive == userParameters.IsActive)
				.CountAsync();

			return PagedList<User>.ToPagedList(userEntities, count, userParameters.PageNumber, userParameters.PageSize);
		}

		public async Task<User?> GetUserByCccd(string cccd, bool trackChange) => await FindByCondition(u => u.CCCD == cccd, trackChange).Include(u => u.Role).SingleOrDefaultAsync();

		public async Task<User?> GetUserByEmail(string email, bool trackChange) => await FindByCondition(u => u.Email == email, trackChange).Include(u => u.Role).SingleOrDefaultAsync();

		public async Task<User?> GetUserById(Guid id, bool trackChange) => await FindByCondition(u => u.Id == id, trackChange).Include(u => u.Role).SingleOrDefaultAsync();

		public async Task<User?> GetUserByUserName(string userName, bool trackChange) => await FindByCondition(u => u.Username == userName, trackChange).Include(u => u.Role).SingleOrDefaultAsync();

		public Task<User?> GetUserByUsernameAndPassword(string username, string password, bool trackChange) => FindByCondition(u => u.Username == username && u.Password == password, trackChange).SingleOrDefaultAsync();
	}
}
