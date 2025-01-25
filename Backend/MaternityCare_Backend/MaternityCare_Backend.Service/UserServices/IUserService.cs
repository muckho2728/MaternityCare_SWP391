using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.UserServices.DTOs;

namespace MaternityCare_Backend.Service.UserServices
{
	public interface IUserService
	{
		Task CreateUser(UserForCreationDto userForCreationDto);
		Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
		Task<TokenDto> CreateToken(bool populateExp);
		Task<TokenDto> RefreshToken(TokenDto tokenDto);
		Task<UserForReturnDto> GetUserById(Guid userId, bool trackChange);
		Task<UserForReturnDto> GetUserByToken(string jwt, bool trackChange);
		Task<(IEnumerable<UserForReturnDto> users, MetaData metaData)> GetUsers(UserParameters userParameters, bool trackChange);
		Task ChangeActiveStatus(Guid userId);
		Task UpdateUser(Guid userId, UserForUpdateDto userForUpdateDto, bool trackChange);
		Task ConfirmEmail(string token, string email);
		Task SendResetPasswordToken(string email);
		Task ResetPassword(UserForResetPasswordDto userForResetPasswordDto);
		Task UpdatePassword(Guid userId, UserForUpdatePasswordDto userForUpdatePasswordDto);
	}
}
