using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IUserRepository
	{
		public Task<User?> GetUserById(Guid id, bool trackChange);
		public Task<User?> GetUserByEmail(string email, bool trackChange);
		public Task<User?> GetUserByUserName(string userName, bool trackChange);
		public Task<User?> GetUserByCccd(string cccd, bool trackChange);
		public Task<User?> GetUserByUsernameAndPassword(string username, string password, bool trackChange);
		public void CreateUser(User user);
	}
}
