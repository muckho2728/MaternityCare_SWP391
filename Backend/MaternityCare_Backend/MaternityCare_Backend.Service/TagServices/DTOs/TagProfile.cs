using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.TagServices.DTOs
{
	public class TagProfile : Profile
	{
		public TagProfile()
		{
			CreateMap<Tag, TagForReturnDto>();
		}
	}
}
