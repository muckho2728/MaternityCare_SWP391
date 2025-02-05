namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IRepositoryManager
	{
		IUserRepository UserRepository { get; }
		IRoleRepository RoleRepository { get; }
		IFeedbackRepository FeedbackRepository { get; }
		ISubscriptionRepository SubscriptionRepository { get; }
		IPackageRepository PackageRepository { get; }
		IAppointmentRepository AppointmentRepository { get; }
		ITransactionRepository TransactionRepository { get; }
		ISlotRepository SlotRepository { get; }
		ILikeRepository LikeRepository { get; }
		IDoctorRepository DoctorRepository { get; }
		IStandardFetusHealthRepository StandardFetusHealthRepository { get; }
		IReminderRepository ReminderRepository { get; }
		ICommentRepository CommentRepository { get; }
		Task SaveAsync(CancellationToken ct = default);
	}
}
