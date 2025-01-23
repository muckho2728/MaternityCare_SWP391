namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IRepositoryManager
	{
		IUserRepository UserRepository { get; }
		IRoleRepository RoleRepository { get; }
		IFeedbackRepository FeedbackRepository { get; }
		Task SaveAsync();
	}
}
