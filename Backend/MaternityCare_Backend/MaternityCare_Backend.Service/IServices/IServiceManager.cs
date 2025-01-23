﻿using MaternityCare_Backend.Service.FeedbackServices;
using MaternityCare_Backend.Service.UserServices;

namespace MaternityCare_Backend.Service.IServices
{
	public interface IServiceManager
	{
		IUserService UserService { get; }
		IFeedbackService FeedbackService { get; }
	}
}
