using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.BlogServices.DTOs
{
	public class BlogProfile : Profile
	{
		public BlogProfile()
		{
			CreateMap<Blog, BlogForReturnDto>();
			CreateMap<BlogForCreationDto, Blog>().ForMember(b => b.Image, opt => opt.Ignore());
			CreateMap<BlogForUpdateDto, Blog>().ForMember(b => b.Image, opt => opt.Ignore());
		}
	}
}
