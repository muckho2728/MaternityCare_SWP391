using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<UserForCreationDto, User>().ForSourceMember(c => c.Password, opt => opt.DoNotValidate());
			CreateMap<User, UserForReturnDto>();
		}
	}
}
