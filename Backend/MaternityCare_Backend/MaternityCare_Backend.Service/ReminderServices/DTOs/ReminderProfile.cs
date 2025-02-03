using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.ReminderServices.DTOs
{
	public class ReminderProfile : Profile
	{
		public ReminderProfile()
		{
			CreateMap<Reminder, ReminderForReturnDto>();
		}
	}
}
