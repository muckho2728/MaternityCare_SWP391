using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;

namespace MaternityCare_Backend.Service.SubscriptionServices
{
	public interface ISubscriptionService
	{
		Task<string> CreateSubscription(SubscriptionForCreationDto subscriptionForCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptions(SubscriptionParameters subscriptionParameters, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, bool trackChange, CancellationToken ct = default);
		Task<SubscriptionForReturnDto?> GetSubscription(Guid subscriptionId, bool trackChange, CancellationToken ct = default);

	}
}
