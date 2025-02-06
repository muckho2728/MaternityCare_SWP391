using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.FetusHealthServices.DTOs
{
	public class FetusHealthProfile : Profile
	{
		public FetusHealthProfile()
		{
			CreateMap<FetusHealthForCreationDto, FetusHealth>();
			CreateMap<FetusHealth, FetusHealthForReturnDto>();
		}
	}
}
