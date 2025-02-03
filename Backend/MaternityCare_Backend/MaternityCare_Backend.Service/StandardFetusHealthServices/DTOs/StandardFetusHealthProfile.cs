using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.StandardFetusHealthServices.DTOs
{
	internal sealed class StandardFetusHealthProfile : Profile
	{
		public StandardFetusHealthProfile()
		{
			CreateMap<StandardFetusHealth, StandardFetusHealthForReturnDto>();
		}
	}
}
