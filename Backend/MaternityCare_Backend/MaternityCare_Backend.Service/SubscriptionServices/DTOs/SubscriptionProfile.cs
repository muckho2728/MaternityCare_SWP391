using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.SubscriptionServices.DTOs
{
	public class SubscriptionProfile : Profile
	{
		public SubscriptionProfile()
		{
			CreateMap<SubscriptionForCreationDto, Subscription>();
			CreateMap<Subscription, SubscriptionForReturnDto>();
		}
	}
}
