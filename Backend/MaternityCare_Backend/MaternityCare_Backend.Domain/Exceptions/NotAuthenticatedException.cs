﻿namespace MaternityCare_Backend.Domain.Exceptions
{
	public class NotAuthenticatedException : Exception
	{
		public NotAuthenticatedException(string? message) : base(message)
		{
		}
	}
}
