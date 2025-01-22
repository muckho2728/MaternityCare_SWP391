using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
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

		public async Task<User?> GetUserByCccd(string cccd, bool trackChange) => await FindByCondition(u => u.CCCD == cccd, trackChange).SingleOrDefaultAsync();

		public async Task<User?> GetUserByEmail(string email, bool trackChange) => await FindByCondition(u => u.Email == email, trackChange).SingleOrDefaultAsync();

		public async Task<User?> GetUserById(Guid id, bool trackChange) => await FindByCondition(u => u.Id == id, trackChange).SingleOrDefaultAsync();

		public async Task<User?> GetUserByUserName(string userName, bool trackChange) => await FindByCondition(u => u.Username == userName, trackChange).SingleOrDefaultAsync();

		public Task<User?> GetUserByUsernameAndPassword(string username, string password, bool trackChange) => FindByCondition(u => u.Username == username && u.Password == password, trackChange).SingleOrDefaultAsync();
	}
}
