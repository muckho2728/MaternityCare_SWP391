using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	public sealed class RepositoryManager : IRepositoryManager
	{
		private readonly RepositoryContext repositoryContext;
		private readonly Lazy<IUserRepository> userRepository;
		private readonly Lazy<IRoleRepository> roleRepository;
		private readonly Lazy<IFeedbackRepository> feedbackRepository;
		private readonly Lazy<ISubscriptionRepository> subscriptionRepository;
		private readonly Lazy<IPackageRepository> packageRepository;
		private readonly Lazy<IAppointmentRepository> appointmentRepository;
		private readonly Lazy<ITransactionRepository> transactionRepository;
		private readonly Lazy<ISlotRepository> slotRepository;
		private readonly Lazy<ILikeRepository> likeRepository;
		private readonly Lazy<IDoctorRepository> doctorRepository;
		private readonly Lazy<IStandardFetusHealthRepository> standardFetusHealthRepository;
		private readonly Lazy<IReminderRepository> reminderRepository;

		public RepositoryManager(RepositoryContext repositoryContext)
		{
			this.repositoryContext = repositoryContext;
			this.userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
			this.roleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(repositoryContext));
			this.feedbackRepository = new Lazy<IFeedbackRepository>(() => new FeedbackRepository(repositoryContext));
			this.subscriptionRepository = new Lazy<ISubscriptionRepository>(() => new SubscriptionRepository(repositoryContext));
			this.packageRepository = new Lazy<IPackageRepository>(() => new PackageRepository(repositoryContext));
			this.appointmentRepository = new Lazy<IAppointmentRepository>(() => new AppointmentRepository(repositoryContext));
			this.transactionRepository = new Lazy<ITransactionRepository>(() => new TransactionRepository(repositoryContext));
			this.slotRepository = new Lazy<ISlotRepository>(() => new SlotRepository(repositoryContext));
			this.likeRepository = new Lazy<ILikeRepository>(() => new LikeRepository(repositoryContext));
			this.doctorRepository = new Lazy<IDoctorRepository>(() => new DoctorRepository(repositoryContext));
			this.standardFetusHealthRepository = new Lazy<IStandardFetusHealthRepository>(() => new StandardFetusHealthRepository(repositoryContext));
			this.reminderRepository = new Lazy<IReminderRepository>(() => new ReminderRepository(repositoryContext));
		}

		public IUserRepository UserRepository => userRepository.Value;

		public IRoleRepository RoleRepository => roleRepository.Value;

		public IFeedbackRepository FeedbackRepository => feedbackRepository.Value;

		public ISubscriptionRepository SubscriptionRepository => subscriptionRepository.Value;

		public IPackageRepository PackageRepository => packageRepository.Value;

		public IAppointmentRepository AppointmentRepository => appointmentRepository.Value;

		public ITransactionRepository TransactionRepository => transactionRepository.Value;

		public ISlotRepository SlotRepository => slotRepository.Value;

		public ILikeRepository LikeRepository => likeRepository.Value;

		public IDoctorRepository DoctorRepository => doctorRepository.Value;

		public IStandardFetusHealthRepository StandardFetusHealthRepository => standardFetusHealthRepository.Value;

		public IReminderRepository ReminderRepository => reminderRepository.Value;

		public Task SaveAsync(CancellationToken ct = default) => repositoryContext.SaveChangesAsync(ct);
	}
}
