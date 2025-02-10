using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.FetusServices.DTOs
{
	public class FetusProfile : Profile
	{
		public FetusProfile()
		{
			CreateMap<FetusForCreationDto, Fetus>();
			CreateMap<FetusForUpdateDto, Fetus>();
			CreateMap<Fetus, FetusForReturnDto>();
		}
	}
}
