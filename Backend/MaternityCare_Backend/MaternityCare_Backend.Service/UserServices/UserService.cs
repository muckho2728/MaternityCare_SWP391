using AutoMapper;
using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.EmailServices;
using MaternityCare_Backend.Service.EmailServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.Jobs;
using MaternityCare_Backend.Service.UserServices.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Quartz;
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
		private readonly IEmailSender emailSender;
		private readonly IHttpContextAccessor httpContextAccessor;
		private readonly ISchedulerFactory schedulerFactory;
		private User? user;

		public UserService(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IBlobService blobService, IPasswordHasher<User> passwordHasher, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor, ISchedulerFactory schedulerFactory)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.configuration = configuration;
			this.blobService = blobService;
			this.passwordHasher = passwordHasher;
			this.emailSender = emailSender;
			this.httpContextAccessor = httpContextAccessor;
			this.schedulerFactory = schedulerFactory;
		}

		private async Task CheckUserExistWhenRegister(string username, string email, string cccd, CancellationToken ct = default)
		{
			var user = await repositoryManager.UserRepository.GetUserByEmail(email, false, ct);
			if (user != null)
			{
				throw new UserBadRequestException("Email already existed");
			}
			user = await repositoryManager.UserRepository.GetUserByUserName(username, false, ct);
			if (user != null)
			{
				throw new UserBadRequestException("Username already existed");
			}
			user = await repositoryManager.UserRepository.GetUserByCccd(cccd, false, ct);
			if (user != null)
			{
				throw new UserBadRequestException("CCCD already existed");
			}
		}

		private async Task<User?> CheckUserExistById(Guid userId, bool trackChange, CancellationToken ct = default)
		{
			var user = await repositoryManager.UserRepository.GetUserById(userId, trackChange, ct);
			if (user == null) throw new UserNotFoundException();
			return user;
		}

		public async Task CreateUser(UserForCreationDto userForCreationDto, CancellationToken ct = default)
		{
			await CheckUserExistWhenRegister(userForCreationDto.Username, userForCreationDto.Email, userForCreationDto.CCCD);
			var userEntity = mapper.Map<User>(userForCreationDto);
			userEntity.Avatar = "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=";
			userEntity.Password = passwordHasher.HashPassword(userEntity, userForCreationDto.Password);
			userEntity.RoleId = await repositoryManager.RoleRepository.GetIdByRoleName(Domain.Constants.Roles.Member, false);
			userEntity.IsActive = true;
			userEntity.CreatedAt = DateTime.Now;
			userEntity.EmailConfirmationToken = GenerateToken();

			repositoryManager.UserRepository.CreateUser(userEntity);
			await repositoryManager.SaveAsync(ct);

			var param = new Dictionary<string, string>
			{
				{ "token", userEntity.EmailConfirmationToken },
				{ "email", userEntity.Email }
			};
			var request = httpContextAccessor.HttpContext?.Request;
			var uri = $"{request?.Scheme}://{request?.Host}/api/authentications/email-verification";
			var callback = QueryHelpers.AddQueryString(uri, param);
			//var mail = new Mail(userEntity.Email, "Email verification", $"<p>Please click <a href='{callback}'>here</a> to verify your email</p>");
			//emailSender.SendEmail(mail);

			IJobDetail job = JobBuilder.Create<EmailSendingJob>()
			.WithIdentity("emailJob", "emailGroup")
			.UsingJobData("to", userEntity.Email)
			.UsingJobData("subject", "Email verification")
			.UsingJobData("body", $"<p>Please click <a href='{callback}'>here</a> to verify your email</p>")
			.Build();

			ITrigger trigger = TriggerBuilder.Create()
		   .WithIdentity("emailTrigger", "emailGroup")
		   .StartNow()
		   .Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}

		public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth, CancellationToken ct = default)
		{
			user = await repositoryManager.UserRepository.GetUserByUserName(userForAuth.Username, true, ct);
			if (user is null)
			{
				user = await repositoryManager.UserRepository.GetUserByEmail(userForAuth.Username, true, ct);
			}
			if (user is null || (passwordHasher.VerifyHashedPassword(user, user.Password, userForAuth.Password) == PasswordVerificationResult.Failed))
			{
				throw new NotAuthenticatedException("Username or password is incorrect");
			}
			if (!user.IsActive)
			{
				throw new NotAuthenticatedException("User is deactivated");
			}
			if (!user.IsEmailConfirmed)
			{
				throw new NotAuthenticatedException("Your email has not been confirmed yet");
			}
			return true;
		}

		public async Task<TokenDto> CreateToken(bool populateExp, CancellationToken ct = default)
		{
			var signingCredentials = GetSigningCredentials();
			var claims = await GetClaims();
			var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

			var refreshToken = GenerateToken();

			user.RefreshToken = refreshToken;

			if (populateExp)
				user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

			await repositoryManager.SaveAsync(ct);

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

		private string GenerateToken()
		{
			var randomNumber = new byte[32];
			using (var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(randomNumber);
				return Convert.ToBase64String(randomNumber);
			}
		}

		private string GenerateOTP()
		{
			Random random = new Random();
			int otp = random.Next(100000, 999999);
			return otp.ToString();
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

		public async Task<TokenDto> RefreshToken(TokenDto tokenDto, CancellationToken ct = default)
		{
			var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
			var currentUser = await repositoryManager.UserRepository.GetUserByUserName(principal.Identity.Name, true, ct);
			if (currentUser == null || currentUser.RefreshToken != tokenDto.RefreshToken || currentUser.RefreshTokenExpiryTime <= DateTime.Now)
			{
				throw new RequestTokenBadRequest();
			}
			user = currentUser;
			return await CreateToken(populateExp: false, ct);
		}

		public async Task<UserForReturnDto> GetUserById(Guid userId, CancellationToken ct = default)
		{
			var userEntity = await CheckUserExistById(userId, false, ct);
			var subscription = await repositoryManager.SubscriptionRepository.GetSubscriptionsByUserId(userId, false, ct);
			var isPremium = subscription.Any(sub => sub.EndDate >= DateOnly.FromDateTime(DateTime.Now) && sub.Package.Id == Guid.Parse("e401f557-307a-4b1d-b65b-d7c26f3aac61"));
			var userReturnDto = mapper.Map<UserForReturnDto>(userEntity);
			userReturnDto.Subscription = isPremium ? "Premium" : "Free";
			return userReturnDto;
		}

		public async Task<UserForReturnDto> GetUserByToken(string jwt, CancellationToken ct = default)
		{
			var handler = new JwtSecurityTokenHandler();
			var token = handler.ReadJwtToken(jwt);
			var userId = Guid.Parse(token.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value);
			return await GetUserById(userId, ct);
		}

		public async Task<(IEnumerable<UserForReturnDto> users, MetaData metaData)> GetUsers(UserParameters userParameters, CancellationToken ct = default)
		{
			var usersWithMetaData = await repositoryManager.UserRepository.GetUsers(userParameters, false, ct);
			var userDto = mapper.Map<IEnumerable<UserForReturnDto>>(usersWithMetaData);
			return (userDto, usersWithMetaData.MetaData);
		}

		public async Task ChangeActiveStatus(Guid userId, CancellationToken ct = default)
		{
			var userEntity = await repositoryManager.UserRepository.GetUserById(userId, true, ct);
			if (userEntity == null) throw new UserNotFoundException();

			userEntity.IsActive = !userEntity.IsActive;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateUser(Guid userId, UserForUpdateDto userForUpdateDto, CancellationToken ct = default)
		{
			var userEntity = await CheckUserExistById(userId, true, ct);
			mapper.Map(userForUpdateDto, userEntity);
			if (userForUpdateDto.Avatar is not null && userForUpdateDto.Avatar.Length > 0)
			{
				await blobService.DeleteBlob(userEntity.Avatar.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(userForUpdateDto.Avatar.FileName)}";
				userEntity.Avatar = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, userForUpdateDto.Avatar);
			}
			userEntity.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task ConfirmEmail(string token, string email, CancellationToken ct = default)
		{
			var userEntity = await repositoryManager.UserRepository.GetUserByEmail(email, true, ct);
			if (userEntity is null || userEntity.EmailConfirmationToken != token) throw new RequestTokenBadRequest();
			userEntity.IsEmailConfirmed = true;
			userEntity.EmailConfirmationToken = null;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task SendResetPasswordToken(string email, CancellationToken ct = default)
		{
			var userEntity = await repositoryManager.UserRepository.GetUserByEmail(email, true, ct);
			if (userEntity is null) throw new UserNotFoundException();

			userEntity.PasswordResetToken = GenerateOTP();
			userEntity.PasswordResetTokenExpiryTime = DateTime.Now.AddHours(1);
			await repositoryManager.SaveAsync(ct);

			var mail = new Mail(userEntity.Email, "Reset password token", $"<p>Your reset password token is: <i>{userEntity.PasswordResetToken}</i></p>");
			emailSender.SendEmail(mail);
		}

		public async Task ResetPassword(UserForResetPasswordDto userForResetPasswordDto, CancellationToken ct = default)
		{
			var userEntity = await repositoryManager.UserRepository.GetUserByEmail(userForResetPasswordDto.Email, true, ct);
			if (userEntity is null || userEntity.PasswordResetToken != userForResetPasswordDto.OTP || userEntity.PasswordResetTokenExpiryTime <= DateTime.Now)
			{
				throw new RequestTokenBadRequest();
			}

			userEntity.Password = passwordHasher.HashPassword(userEntity, userForResetPasswordDto.Password);
			userEntity.PasswordResetToken = null;
			userEntity.PasswordResetTokenExpiryTime = null;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdatePassword(Guid userId, UserForUpdatePasswordDto userForUpdatePasswordDto, CancellationToken ct = default)
		{
			var userEntity = await CheckUserExistById(userId, true, ct);
			if (passwordHasher.VerifyHashedPassword(userEntity, userEntity.Password, userForUpdatePasswordDto.CurrentPassword) == PasswordVerificationResult.Failed)
			{
				throw new UserBadRequestException("Old password is incorrect");
			}
			userEntity.Password = passwordHasher.HashPassword(userEntity, userForUpdatePasswordDto.NewPassword);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
