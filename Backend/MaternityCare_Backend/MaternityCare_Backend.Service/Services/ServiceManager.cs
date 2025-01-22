using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.UserServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace MaternityCare_Backend.Service.Services
{
	public sealed class ServiceManager : IServiceManager
	{
		private readonly Lazy<IUserService> userService;
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IPasswordHasher<User> passwordHasher, IBlobService blobService)
		{
			userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, configuration, blobService, passwordHasher));
		}

		public IUserService UserService => userService.Value;
	}
}
