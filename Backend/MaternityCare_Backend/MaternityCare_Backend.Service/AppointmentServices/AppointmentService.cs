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

		private async Task<Appointment> CheckAppointmentExist(Guid userId, Guid slotId, bool trackChange, CancellationToken ct = default)
		{
			var appointment = await repositoryManager.AppointmentRepository.GetAppointment(userId, slotId, trackChange, ct);
			if (appointment == null) throw new AppointmentNotFoundException();
			return appointment;
		}

		public async Task CreateAppointment(Guid userId, Guid slotId, CancellationToken ct = default)
		{
			var appointment = await repositoryManager.AppointmentRepository.GetAppointmentsByUserId(userId, false, ct);
			var slotEntity = await repositoryManager.SlotRepository.GetSlot(slotId, false, ct);
			if (appointment.Any(a => a.Slot.Date == slotEntity.Date)) throw new AppointmentConflictException("You have already booked an appointment today");
			if (slotEntity.IsBooked) throw new SlotConflictException("This slot is already booked");
			var appointmentEntity = new Appointment()
			{
				UserId = userId,
				SlotId = slotId,
				CreatedAt = DateTime.Now
			};
			repositoryManager.AppointmentRepository.CreateAppointment(appointmentEntity);

			var slot = await repositoryManager.SlotRepository.GetSlot(slotId, true, ct);
			slot.IsBooked = true;

			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteAppointment(Guid userId, Guid slotId, CancellationToken ct = default)
		{
			var appointment = await CheckAppointmentExist(userId, slotId, false, ct);
			if (appointment.Slot.Date <= DateOnly.FromDateTime(DateTime.Now)) throw new AppointmentConflictException("You cannot cancel appointments that occur today or before");
			repositoryManager.AppointmentRepository.DeleteAppointment(appointment);

			var slot = await repositoryManager.SlotRepository.GetSlot(appointment.SlotId, true, ct);
			slot.IsBooked = false;

			await repositoryManager.SaveAsync(ct);
		}

		public async Task<AppointmentForReturnDto?> GetAppointment(Guid userId, Guid slotId, CancellationToken ct = default)
		{
			var appointmentEntity = await CheckAppointmentExist(userId, slotId, false, ct);
			return mapper.Map<AppointmentForReturnDto>(appointmentEntity);
		}

		public async Task<(IEnumerable<AppointmentForReturnDto> appointments, MetaData metaData)> GetAppointments(Guid userId, AppointmentParameters appointmentParameters, CancellationToken ct = default)
		{
			var appointmentsWithMetaData = await repositoryManager.AppointmentRepository.GetAppointments(userId, appointmentParameters, false, ct);
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
