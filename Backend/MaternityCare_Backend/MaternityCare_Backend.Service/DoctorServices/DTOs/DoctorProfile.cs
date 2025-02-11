using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.DoctorServices.DTOs
{
	public class DoctorProfile : Profile
	{
		public DoctorProfile()
		{
			CreateMap<Doctor, DoctorForReturnDto>();
			CreateMap<DoctorForCreationDto, Doctor>();
			CreateMap<DoctorForUpdateDto, Doctor>();
		}
	}
}
