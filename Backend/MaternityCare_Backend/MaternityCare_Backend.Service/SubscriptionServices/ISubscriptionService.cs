using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;

namespace MaternityCare_Backend.Service.SubscriptionServices
{
	public interface ISubscriptionService
	{
		Task<SubscriptionForReturnDto> CreateSubscription(SubscriptionForCreationDto subscriptionForCreationDto);
		Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptions(SubscriptionParameters subscriptionParameters, bool trackChange);
		Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, bool trackChange);
		Task<SubscriptionForReturnDto?> GetSubscription(Guid subscriptionId, bool trackChange);

	}
}
