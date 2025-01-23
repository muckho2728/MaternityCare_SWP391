using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.FeedbackServices.DTOs
{
	public class FeedbackProfile : Profile
	{
		public FeedbackProfile()
		{
			CreateMap<FeedbackForCreationDto, Feedback>();
			CreateMap<Feedback, FeedbackForReturnDto>();
		}
	}
}
