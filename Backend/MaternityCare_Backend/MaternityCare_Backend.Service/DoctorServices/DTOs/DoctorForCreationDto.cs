﻿namespace MaternityCare_Backend.Service.DoctorServices.DTOs
{
	public record DoctorForCreationDto
	{
		public string Avatar { get; init; }
		public string FullName { get; init; }
		public string Email { get; init; }
		public string PhoneNumber { get; init; }
		public string Specialization { get; init; }
		public double YearsOfExperience { get; init; }
	}
}
