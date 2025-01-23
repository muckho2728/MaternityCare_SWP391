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

		public RepositoryManager(RepositoryContext repositoryContext)
		{
			this.repositoryContext = repositoryContext;
			this.userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
			this.roleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(repositoryContext));
			this.feedbackRepository = new Lazy<IFeedbackRepository>(() => new FeedbackRepository(repositoryContext));
		}

		public IUserRepository UserRepository => userRepository.Value;

		public IRoleRepository RoleRepository => roleRepository.Value;

		public IFeedbackRepository FeedbackRepository => feedbackRepository.Value;

		public Task SaveAsync() => repositoryContext.SaveChangesAsync();
	}
}
