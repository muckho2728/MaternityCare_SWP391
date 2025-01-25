using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.PackageServices.DTOs
{
	public class PackageProfile : Profile
	{
		public PackageProfile()
		{
			CreateMap<PackageForCreationDto, Package>();
			CreateMap<PackageForUpdateDto, Package>();
			CreateMap<Package, PackageForReturnDto>();
		}
	}
}
