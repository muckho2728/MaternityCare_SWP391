using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class SubscriptionRepository : RepositoryBase<Subscription>, ISubscriptionRepository
	{
		public SubscriptionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateSubscription(Subscription subscription) => Create(subscription);

		public async Task<Subscription?> GetSubscription(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(s => s.Id == id, trackChange)
			.Include(s => s.Package)
			.SingleOrDefaultAsync(ct);

		public async Task<PagedList<Subscription>> GetSubscriptions(SubscriptionParameters subscriptionParameters, bool trackChange, CancellationToken ct = default)
		{
			var subscriptionEntities = FindAll(trackChange)
				.Filter(subscriptionParameters.StartDate, subscriptionParameters.EndDate)
				.Sort()
				.Include(s => s.Package);

			return await PagedList<Subscription>.ToPagedList(subscriptionEntities, subscriptionParameters.PageNumber, subscriptionParameters.PageSize, ct);
		}

		public async Task<PagedList<Subscription>> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, bool trackChange, CancellationToken ct = default)
		{
			var subscriptionEntities = FindByCondition(s => s.UserId == userId, trackChange)
				.Filter(subscriptionParameters.StartDate, subscriptionParameters.EndDate)
				.Sort()
				.Include(s => s.Package);

			return await PagedList<Subscription>.ToPagedList(subscriptionEntities, subscriptionParameters.PageNumber, subscriptionParameters.PageSize, ct);
		}
	}
}
