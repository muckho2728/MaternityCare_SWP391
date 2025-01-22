using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.UserServices.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace MaternityCare_Backend.Service.UserServices
{
	internal sealed class UserService : IUserService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IConfiguration configuration;
		private readonly IBlobService blobService;
		private readonly IPasswordHasher<User> passwordHasher;

		public UserService(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IBlobService blobService, IPasswordHasher<User> passwordHasher)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.configuration = configuration;
			this.blobService = blobService;
			this.passwordHasher = passwordHasher;
		}

		private async Task CheckUserExistWhenRegister(string username, string email, string cccd)
		{
			var user = await repositoryManager.UserRepository.GetUserByEmail(email, false);
			if (user != null)
			{
				throw new UserBadRequestException("Email already existed");
			}
			user = await repositoryManager.UserRepository.GetUserByUserName(username, false);
			if (user != null)
			{
				throw new UserBadRequestException("Username already existed");
			}
			user = await repositoryManager.UserRepository.GetUserByCccd(cccd, false);
			if (user != null)
			{
				throw new UserBadRequestException("CCCD already existed");
			}
		}

		public async Task CreateUser(UserForCreationDto userForCreationDto)
		{
			await CheckUserExistWhenRegister(userForCreationDto.Username, userForCreationDto.Email, userForCreationDto.CCCD);
			var userEntity = mapper.Map<User>(userForCreationDto);
			userEntity.Avatar = "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=";
			userEntity.Password = passwordHasher.HashPassword(userEntity, userForCreationDto.Password);
			userEntity.RoleId = await repositoryManager.RoleRepository.GetIdByRoleName(Domain.Constants.Roles.Member, false);
			userEntity.IsActive = true;

			repositoryManager.UserRepository.CreateUser(userEntity);
			await repositoryManager.SaveAsync();
		}
	}
}
