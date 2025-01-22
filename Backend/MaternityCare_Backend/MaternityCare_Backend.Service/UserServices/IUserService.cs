using MaternityCare_Backend.Service.UserServices.DTOs;

namespace MaternityCare_Backend.Service.UserServices
{
	public interface IUserService
	{
		public Task CreateUser(UserForCreationDto userForCreationDto);
	}
}
