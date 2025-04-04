﻿using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.AppointmentServices;
using MaternityCare_Backend.Service.BlogServices;
using MaternityCare_Backend.Service.CommentServices;
using MaternityCare_Backend.Service.DoctorServices;
using MaternityCare_Backend.Service.EmailServices;
using MaternityCare_Backend.Service.FeedbackServices;
using MaternityCare_Backend.Service.FetusHealthServices;
using MaternityCare_Backend.Service.FetusServices;
using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.LikeServices;
using MaternityCare_Backend.Service.PackageServices;
using MaternityCare_Backend.Service.ReminderServices;
using MaternityCare_Backend.Service.SlotServices;
using MaternityCare_Backend.Service.StandardFetusHealthServices;
using MaternityCare_Backend.Service.SubscriptionServices;
using MaternityCare_Backend.Service.TagServices;
using MaternityCare_Backend.Service.TransactionServices;
using MaternityCare_Backend.Service.UserServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Quartz;

namespace MaternityCare_Backend.Service.Services
{
	public sealed class ServiceManager : IServiceManager
	{
		private readonly Lazy<IUserService> userService;
		private readonly Lazy<IFeedbackService> feedbackService;
		private readonly Lazy<IPackageService> packageService;
		private readonly Lazy<ISubscriptionService> subscriptionService;
		private readonly Lazy<IAppointmentService> appointmentService;
		private readonly Lazy<ISlotService> slotService;
		private readonly Lazy<ITransactionService> transactionService;
		private readonly Lazy<ILikeService> likeService;
		private readonly Lazy<IDoctorService> doctorService;
		private readonly Lazy<IReminderService> reminderService;
		private readonly Lazy<IStandardFetusHealthService> standardFetusHealthService;
		private readonly Lazy<ICommentService> commentService;
		private readonly Lazy<IFetusService> fetusService;
		private readonly Lazy<IFetusHealthService> fetusHealthService;
		private readonly Lazy<ITagService> tagService;
		private readonly Lazy<IBlogService> blogService;
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IPasswordHasher<User> passwordHasher, IBlobService blobService, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor, Utils utils, ISchedulerFactory schedulerFactory)
		{
			userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, configuration, blobService, passwordHasher, emailSender, httpContextAccessor, schedulerFactory));
			feedbackService = new Lazy<IFeedbackService>(() => new FeedbackService(repositoryManager, mapper));
			packageService = new Lazy<IPackageService>(() => new PackageService(repositoryManager, mapper));
			subscriptionService = new Lazy<ISubscriptionService>(() => new SubscriptionService(repositoryManager, mapper, configuration, utils));
			appointmentService = new Lazy<IAppointmentService>(() => new AppointmentService(repositoryManager, mapper));
			slotService = new Lazy<ISlotService>(() => new SlotService(repositoryManager, mapper));
			transactionService = new Lazy<ITransactionService>(() => new TransactionService(repositoryManager, mapper, utils, configuration));
			likeService = new Lazy<ILikeService>(() => new LikeService(repositoryManager, mapper));
			doctorService = new Lazy<IDoctorService>(() => new DoctorService(repositoryManager, mapper, blobService));
			reminderService = new Lazy<IReminderService>(() => new ReminderService(repositoryManager, mapper));
			standardFetusHealthService = new Lazy<IStandardFetusHealthService>(() => new StandardFetusHealthService(repositoryManager, mapper));
			commentService = new Lazy<ICommentService>(() => new CommentService(repositoryManager, mapper));
			fetusService = new Lazy<IFetusService>(() => new FetusService(repositoryManager, mapper));
			fetusHealthService = new Lazy<IFetusHealthService>(() => new FetusHealthService(repositoryManager, mapper));
			tagService = new Lazy<ITagService>(() => new TagService(repositoryManager, mapper));
			blogService = new Lazy<IBlogService>(() => new BlogService(repositoryManager, mapper, schedulerFactory, blobService));
		}

		public IUserService UserService => userService.Value;

		public IFeedbackService FeedbackService => feedbackService.Value;

		public IPackageService PackageService => packageService.Value;

		public ISubscriptionService SubscriptionService => subscriptionService.Value;

		public IAppointmentService AppointmentService => appointmentService.Value;

		public ISlotService SlotService => slotService.Value;

		public ITransactionService TransactionService => transactionService.Value;

		public ILikeService LikeService => likeService.Value;

		public IDoctorService DoctorService => doctorService.Value;

		public IReminderService ReminderService => reminderService.Value;

		public IStandardFetusHealthService StandardFetusHealthService => standardFetusHealthService.Value;

		public ICommentService CommentService => commentService.Value;

		public IFetusService FetusService => fetusService.Value;

		public IFetusHealthService FetusHealthService => fetusHealthService.Value;

		public ITagService TagService => tagService.Value;

		public IBlogService BlogService => blogService.Value;
	}
}
