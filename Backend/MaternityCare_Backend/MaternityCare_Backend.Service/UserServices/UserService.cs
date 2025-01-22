using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.UserServices.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace MaternityCare_Backend.Service.UserServices
{
	internal sealed class UserService : IUserService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IConfiguration configuration;
		private readonly IBlobService blobService;
		private readonly IPasswordHasher<User> passwordHasher;
		private User? user;

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
			userEntity.CreatedAt = DateTime.Now;

			repositoryManager.UserRepository.CreateUser(userEntity);
			await repositoryManager.SaveAsync();
		}

		public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
		{
			user = await repositoryManager.UserRepository.GetUserByUserName(userForAuth.Username, true);
			if (user is null || (passwordHasher.VerifyHashedPassword(user, user.Password, userForAuth.Password) == PasswordVerificationResult.Failed))
			{
				throw new NotAuthenticatedException("Username or password is incorrect");
			}
			if (!user.IsActive)
			{
				throw new NotAuthenticatedException("User is deactivated");
			}
			return true;
		}

		public async Task<TokenDto> CreateToken(bool populateExp)
		{
			var signingCredentials = GetSigningCredentials();
			var claims = await GetClaims();
			var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

			var refreshToken = GenerateRefreshToken();

			user.RefreshToken = refreshToken;

			if (populateExp)
				user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

			await repositoryManager.SaveAsync();

			var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

			return new TokenDto
			{
				AccessToken = accessToken,
				RefreshToken = refreshToken
			};
		}

		private SigningCredentials GetSigningCredentials()
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var key = Encoding.UTF8.GetBytes(jwtSettings["secretKey"]!);
			var secret = new SymmetricSecurityKey(key);
			return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
		}
		private async Task<List<Claim>> GetClaims()
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, user!.Username!)
			};
			claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
			claims.Add(new Claim(ClaimTypes.Role, user.Role.Name));
			return claims;
		}
		private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials,
			List<Claim> claims)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var tokenOptions = new JwtSecurityToken
			(
				issuer: jwtSettings["validIssuer"],
				audience: jwtSettings["validAudience"],
				claims: claims,
				expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
				signingCredentials: signingCredentials
			);
			return tokenOptions;
		}

		private string GenerateRefreshToken()
		{
			var randomNumber = new byte[32];
			using (var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(randomNumber);
				return Convert.ToBase64String(randomNumber);
			}
		}

		private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");

			var tokenValidationParameters = new TokenValidationParameters
			{
				ValidateAudience = true,
				ValidateIssuer = true,
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(
					Encoding.UTF8.GetBytes(jwtSettings["secretKey"])),
				ValidateLifetime = true,
				ValidIssuer = jwtSettings["validIssuer"],
				ValidAudience = jwtSettings["validAudience"]
			};

			var tokenHandler = new JwtSecurityTokenHandler();
			SecurityToken securityToken;
			var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

			var jwtSecurityToken = securityToken as JwtSecurityToken;
			if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
				StringComparison.InvariantCultureIgnoreCase))
			{
				throw new SecurityTokenException("Invalid token");
			}

			return principal;
		}

		public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
		{
			var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
			var currentUser = await repositoryManager.UserRepository.GetUserByUserName(principal.Identity.Name, true);
			if (currentUser == null || currentUser.RefreshToken != tokenDto.RefreshToken || currentUser.RefreshTokenExpiryTime <= DateTime.Now)
			{
				throw new RequestTokenBadRequest();
			}
			user = currentUser;
			return await CreateToken(populateExp: false);
		}

		public async Task<UserForReturnDto> GetUserById(Guid userId, bool trackChange)
		{
			var userEntity = await repositoryManager.UserRepository.GetUserById(userId, trackChange);
			if (userEntity == null) throw new UserNotFoundException(userId);

			return mapper.Map<UserForReturnDto>(userEntity);
		}

		public Task<UserForReturnDto> GetUserByToken(string jwt, bool trackChange)
		{
			var handler = new JwtSecurityTokenHandler();
			var token = handler.ReadJwtToken(jwt);
			var userId = Guid.Parse(token.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value);
			return GetUserById(userId, trackChange);
		}
	}
}
