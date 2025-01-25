using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.EmailServices;
using MaternityCare_Backend.Service.FeedbackServices;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.PackageServices;
using MaternityCare_Backend.Service.UserServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace MaternityCare_Backend.Service.Services
{
	public sealed class ServiceManager : IServiceManager
	{
		private readonly Lazy<IUserService> userService;
		private readonly Lazy<IFeedbackService> feedbackService;
		private readonly Lazy<IPackageService> packageService;
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IPasswordHasher<User> passwordHasher, IBlobService blobService, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor)
		{
			userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, configuration, blobService, passwordHasher, emailSender, httpContextAccessor));
			feedbackService = new Lazy<IFeedbackService>(() => new FeedbackService(repositoryManager, mapper));
			packageService = new Lazy<IPackageService>(() => new PackageService(repositoryManager, mapper));
		}

		public IUserService UserService => userService.Value;

		public IFeedbackService FeedbackService => feedbackService.Value;

		public IPackageService PackageService => packageService.Value;
	}
}
