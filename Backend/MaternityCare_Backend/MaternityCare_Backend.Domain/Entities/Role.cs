﻿namespace MaternityCare_Backend.Domain.Entities
{
	public class Role
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		//Navigation properties
		public ICollection<User> Users { get; set; }
	}
}
