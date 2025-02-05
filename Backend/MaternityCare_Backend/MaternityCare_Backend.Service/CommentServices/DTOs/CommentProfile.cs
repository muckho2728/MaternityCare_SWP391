using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.CommentServices.DTOs
{
	public class CommentProfile : Profile
	{
		public CommentProfile()
		{
			CreateMap<CommentForCreationDto, Comment>();
			CreateMap<CommentForUpdateDto, Comment>();
			CreateMap<Comment, CommentForReturnDto>();
		}
	}
}
