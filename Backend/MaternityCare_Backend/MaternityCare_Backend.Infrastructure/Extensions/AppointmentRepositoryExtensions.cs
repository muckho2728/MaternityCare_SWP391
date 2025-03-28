﻿using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Infrastructure.Extensions
{
	public static class AppointmentRepositoryExtensions
	{
		public static IQueryable<Appointment> Sort(this IQueryable<Appointment> appointments) => appointments.OrderByDescending(x => x.CreatedAt);
	}
}
