using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ISubscriptionRepository
	{
		void CreateSubscription(Subscription subscription);
		Task<PagedList<Subscription>> GetSubscriptions(SubscriptionParameters subscriptionParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Subscription>> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, bool trackChange, CancellationToken ct = default);
		Task<Subscription?> GetSubscription(Guid id, bool trackChange, CancellationToken ct = default);
	}
}
