using MaternityCare_Backend.Service.UserServices.DTOs;

namespace MaternityCare_Backend.Service.UserServices
{
	public interface IUserService
	{
		public Task CreateUser(UserForCreationDto userForCreationDto);
		public Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
		Task<TokenDto> CreateToken(bool populateExp);
		Task<TokenDto> RefreshToken(TokenDto tokenDto);
		Task<UserForReturnDto> GetUserById(Guid userId, bool trackChange);
		Task<UserForReturnDto> GetUserByToken(string jwt, bool trackChange);
	}
}
