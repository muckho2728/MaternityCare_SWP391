using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.SlotServices.DTOs
{
	public class SlotProfile : Profile
	{
		public SlotProfile()
		{
			CreateMap<SlotForCreationDto, Slot>();
			CreateMap<Slot, SlotForReturnDto>();
		}
	}
}
