using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IUserRepository
	{
		Task<PagedList<User>> GetUsers(UserParameters userParameters, bool trackChange);
		Task<User?> GetUserById(Guid id, bool trackChange);
		Task<User?> GetUserByEmail(string email, bool trackChange);
		Task<User?> GetUserByUserName(string userName, bool trackChange);
		Task<User?> GetUserByCccd(string cccd, bool trackChange);
		Task<User?> GetUserByUsernameAndPassword(string username, string password, bool trackChange);
		void CreateUser(User user);
	}
}
