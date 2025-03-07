﻿using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IUserRepository
	{
		Task<PagedList<User>> GetUsers(UserParameters userParameters, bool trackChange, CancellationToken ct = default);
		Task<User?> GetUserById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<User?> GetUserByEmail(string email, bool trackChange, CancellationToken ct = default);
		Task<User?> GetUserByUserName(string userName, bool trackChange, CancellationToken ct = default);
		Task<User?> GetUserByCccd(string cccd, bool trackChange, CancellationToken ct = default);
		Task<User?> GetUserByUsernameAndPassword(string username, string password, bool trackChange, CancellationToken ct = default);
		void CreateUser(User user);
	}
}
