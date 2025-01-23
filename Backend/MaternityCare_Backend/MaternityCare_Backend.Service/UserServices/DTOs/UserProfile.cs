using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.UserServices.DTOs
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<UserForCreationDto, User>().ForMember(c => c.Password, opt => opt.Ignore());
			CreateMap<UserForUpdateDto, User>().ForMember(c => c.Avatar, opt => opt.Ignore());
			CreateMap<User, UserForReturnDto>();
		}
	}
}
