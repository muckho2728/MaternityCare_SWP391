using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.AppointmentServices.DTOs;
using OfficeOpenXml;

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

		private async Task<Appointment> CheckAppointmentExist(Guid appointmentId, bool trackChange, CancellationToken ct = default)
		{
			var appointment = await repositoryManager.AppointmentRepository.GetAppointment(appointmentId, trackChange, ct);
			if (appointment == null) throw new AppointmentNotFoundException();
			return appointment;
		}

		public async Task CreateAppointment(AppointmentForCreationDto appointmentForCreationDto, CancellationToken ct = default)
		{
			var slotEntity = await repositoryManager.SlotRepository.GetSlot(appointmentForCreationDto.SlotId, false, ct);
			if (slotEntity.IsBooked) throw new SlotConflictException("This slot is already booked");
			var appointmentEntity = mapper.Map<Appointment>(appointmentForCreationDto);
			appointmentEntity.CreatedAt = DateTime.Now;
			repositoryManager.AppointmentRepository.CreateAppointment(appointmentEntity);

			var slot = await repositoryManager.SlotRepository.GetSlot(appointmentEntity.SlotId, true, ct);
			slot.IsBooked = true;

			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteAppointment(Guid appointmentId, bool trackChange, CancellationToken ct = default)
		{
			var appointment = await CheckAppointmentExist(appointmentId, trackChange, ct);
			if (appointment.Slot.Date <= DateOnly.FromDateTime(DateTime.Now)) throw new AppointmentConflictException("You cannot cancel appointments that occur today or before");
			repositoryManager.AppointmentRepository.DeleteAppointment(appointment);

			var slot = await repositoryManager.SlotRepository.GetSlot(appointment.SlotId, true, ct);
			slot.IsBooked = false;

			await repositoryManager.SaveAsync(ct);
		}

		public async Task<AppointmentForReturnDto?> GetAppointment(Guid appointmentId, bool trackChange, CancellationToken ct = default)
		{
			var appointmentEntity = await CheckAppointmentExist(appointmentId, trackChange, ct);
			return mapper.Map<AppointmentForReturnDto>(appointmentEntity);
		}

		public async Task<(IEnumerable<AppointmentForReturnDto> appointments, MetaData metaData)> GetAppointments(AppointmentParameters appointmentParameters, bool trackChange, CancellationToken ct = default)
		{
			var appointmentsWithMetaData = await repositoryManager.AppointmentRepository.GetAppointments(appointmentParameters, trackChange, ct);
			var appointmentsDto = mapper.Map<IEnumerable<AppointmentForReturnDto>>(appointmentsWithMetaData);
			return (appointmentsDto, appointmentsWithMetaData.MetaData);
		}

		public async Task<byte[]> GenerateExcel(DateOnly date, CancellationToken ct = default)
		{
			var doctors = await repositoryManager.DoctorRepository.GetDoctors(false, ct);
			using (var package = new ExcelPackage())
			{
				foreach (var doctor in doctors)
				{
					var worksheet = package.Workbook.Worksheets.Add(doctor.FullName);
					var appointments = await repositoryManager.AppointmentRepository.GetAppointmentsByDoctorIdAndDate(doctor.Id, date, false);

					worksheet.Cells[1, 1].Value = "PatientName";
					worksheet.Cells[1, 2].Value = "CCCD";
					worksheet.Cells[1, 3].Value = "StartTime";
					worksheet.Cells[1, 4].Value = "EndTime";

					for (int i = 0; i < appointments.Count(); i++)
					{
						worksheet.Cells[i + 2, 1].Value = appointments.ElementAt(i).User.FullName;
						worksheet.Cells[i + 2, 2].Value = appointments.ElementAt(i).User.CCCD;
						worksheet.Cells[i + 2, 3].Value = appointments.ElementAt(i).Slot.StartTime.ToString();
						worksheet.Cells[i + 2, 4].Value = appointments.ElementAt(i).Slot.EndTime.ToString();
					}

					worksheet.Cells.AutoFitColumns();
				}
				return package.GetAsByteArray();
			}
		}
	}
}
