using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ISubscriptionRepository
	{
		void CreateSubscription(Subscription subscription);
		Task<PagedList<Subscription>> GetSubscriptions(SubscriptionParameters subscriptionParameters, bool trackChange);
		Task<PagedList<Subscription>> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, bool trackChange);
		Task<Subscription?> GetSubscription(Guid id, bool trackChange);
	}
}
