using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.RoleServices.DTOs
{
	public class RoleProfile : Profile
	{
		public RoleProfile()
		{
			CreateMap<Role, RoleForReturnDto>();
		}
	}
}
