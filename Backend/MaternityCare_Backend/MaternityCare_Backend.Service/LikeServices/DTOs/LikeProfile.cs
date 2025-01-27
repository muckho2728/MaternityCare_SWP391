using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.LikeServices.DTOs
{
	public class LikeProfile : Profile
	{
		public LikeProfile()
		{
			CreateMap<LikeForCreationDto, Like>();
			CreateMap<Like, LikeForReturnDto>();
		}
	}
}
