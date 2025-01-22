﻿namespace MaternityCare_Backend.Domain.Exceptions
{
	public sealed class UserNotFoundException : NotFoundException
	{
		public UserNotFoundException(Guid userId) : base($"The user with id: {userId} doesn't exist")
		{
		}
	}
}
