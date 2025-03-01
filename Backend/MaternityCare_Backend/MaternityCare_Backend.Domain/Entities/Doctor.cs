﻿namespace MaternityCare_Backend.Domain.Entities
{
	public class Doctor
	{
		public Guid Id { get; set; }
		public string Avatar { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Specialization { get; set; }
		public double YearsOfExperience { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }

		// Navigation properties
		public ICollection<Slot> Slots { get; set; }
	}
}
