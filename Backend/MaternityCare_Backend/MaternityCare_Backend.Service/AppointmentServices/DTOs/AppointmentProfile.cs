using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.AppointmentServices.DTOs
{
	public class AppointmentProfile : Profile
	{
		public AppointmentProfile()
		{
			CreateMap<AppointmentForCreationDto, Appointment>();
			CreateMap<Appointment, AppointmentForReturnDto>();
		}
	}
}
