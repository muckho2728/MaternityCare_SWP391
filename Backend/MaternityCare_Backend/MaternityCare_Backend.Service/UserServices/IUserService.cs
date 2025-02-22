using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.UserServices.DTOs;

namespace MaternityCare_Backend.Service.UserServices
{
	public interface IUserService
	{
		Task CreateUser(UserForCreationDto userForCreationDto, CancellationToken ct = default);
		Task<bool> ValidateUser(UserForAuthenticationDto userForAuth, CancellationToken ct = default);
		Task<TokenDto> CreateToken(bool populateExp, CancellationToken ct = default);
		Task<TokenDto> RefreshToken(TokenDto tokenDto, CancellationToken ct = default);
		Task<UserForReturnDto> GetUserById(Guid userId, CancellationToken ct = default);
		Task<UserForReturnDto> GetUserByToken(string jwt, CancellationToken ct = default);
		Task<(IEnumerable<UserForReturnDto> users, MetaData metaData)> GetUsers(UserParameters userParameters, CancellationToken ct = default);
		Task ChangeActiveStatus(Guid userId, CancellationToken ct = default);
		Task UpdateUser(Guid userId, UserForUpdateDto userForUpdateDto, CancellationToken ct = default);
		Task ConfirmEmail(string token, string email, CancellationToken ct = default);
		Task SendResetPasswordToken(string email, CancellationToken ct = default);
		Task ResetPassword(UserForResetPasswordDto userForResetPasswordDto, CancellationToken ct = default);
		Task UpdatePassword(Guid userId, UserForUpdatePasswordDto userForUpdatePasswordDto, CancellationToken ct = default);
	}
}
