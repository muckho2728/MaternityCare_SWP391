using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.AppointmentServices.DTOs;

namespace MaternityCare_Backend.Service.AppointmentServices
{
	internal sealed class AppointmentService : IAppointmentService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public AppointmentService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		private async Task<Appointment> CheckAppointmentExist(Guid appointmentId, bool trackChange)
		{
			var appointment = await repositoryManager.AppointmentRepository.GetAppointment(appointmentId, trackChange);
			if (appointment == null) throw new AppointmentNotFoundException();
			return appointment;
		}

		public async Task CreateAppointment(AppointmentForCreationDto appointmentForCreationDto)
		{
			var appointmentEntity = mapper.Map<Appointment>(appointmentForCreationDto);
			appointmentEntity.CreatedAt = DateTime.Now;
			repositoryManager.AppointmentRepository.CreateAppointment(appointmentEntity);

			var slot = await repositoryManager.SlotRepository.GetSlot(appointmentEntity.SlotId, true);
			slot.IsBooked = true;

			await repositoryManager.SaveAsync();
		}

		public async Task DeleteAppointment(Guid appointmentId, bool trackChange)
		{
			var appointment = await CheckAppointmentExist(appointmentId, trackChange);
			if (appointment.Slot.Date <= DateOnly.FromDateTime(DateTime.Now)) throw new AppointmentConflictException("You cannot cancel appointments that occur today or before");
			repositoryManager.AppointmentRepository.DeleteAppointment(appointment);

			var slot = await repositoryManager.SlotRepository.GetSlot(appointment.SlotId, true);
			slot.IsBooked = false;

			await repositoryManager.SaveAsync();
		}

		public async Task<AppointmentForReturnDto?> GetAppointment(Guid appointmentId, bool trackChange)
		{
			var appointmentEntity = await CheckAppointmentExist(appointmentId, trackChange);
			return mapper.Map<AppointmentForReturnDto>(appointmentEntity);
		}

		public async Task<(IEnumerable<AppointmentForReturnDto> appointments, MetaData metaData)> GetAppointments(AppointmentParameters appointmentParameters, bool trackChange)
		{
			var appointmentsWithMetaData = await repositoryManager.AppointmentRepository.GetAppointments(appointmentParameters, trackChange);
			var appointmentsDto = mapper.Map<IEnumerable<AppointmentForReturnDto>>(appointmentsWithMetaData);
			return (appointmentsDto, appointmentsWithMetaData.MetaData);
		}
	}
}
