using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;

namespace MaternityCare_Backend.Service.SubscriptionServices
{
	public interface ISubscriptionService
	{
		Task<string> CreateSubscription(SubscriptionForCreationDto subscriptionForCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptions(SubscriptionParameters subscriptionParameters, CancellationToken ct = default);
		Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, CancellationToken ct = default);
		Task<SubscriptionForReturnDto?> GetSubscription(Guid subscriptionId, CancellationToken ct = default);

	}
}
