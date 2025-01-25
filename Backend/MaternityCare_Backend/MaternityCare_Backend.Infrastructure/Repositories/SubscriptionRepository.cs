using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Infrastructure.Persistence;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	public class SubscriptionRepository : RepositoryBase<Subscription>, ISubscriptionRepository
	{
		public SubscriptionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}
	}
}
