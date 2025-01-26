using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.SubscriptionServices.DTOs;

namespace MaternityCare_Backend.Service.SubscriptionServices
{
	internal sealed class SubscriptionService : ISubscriptionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public SubscriptionService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		private async Task<Subscription?> CheckSubscriptionExist(Guid subscriptionId, bool trackChange)
		{
			var subscriptionEntity = await repositoryManager.SubscriptionRepository.GetSubscription(subscriptionId, trackChange);
			if (subscriptionEntity == null) throw new SubscriptionNotFoundException();
			return subscriptionEntity;
		}
		public async Task<SubscriptionForReturnDto> CreateSubscription(SubscriptionForCreationDto subscriptionForCreationDto)
		{
			var subscriptionEntity = mapper.Map<Subscription>(subscriptionForCreationDto);
			repositoryManager.SubscriptionRepository.CreateSubscription(subscriptionEntity);
			await repositoryManager.SaveAsync();
			return mapper.Map<SubscriptionForReturnDto>(subscriptionEntity);

		}

		public async Task<SubscriptionForReturnDto?> GetSubscription(Guid subscriptionId, bool trackChange)
		{
			var subscriptionEntity = await CheckSubscriptionExist(subscriptionId, trackChange);
			return mapper.Map<SubscriptionForReturnDto>(subscriptionEntity);
		}

		public async Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptions(SubscriptionParameters subscriptionParameters, bool trackChange)
		{
			var subscriptionWithMetaData = await repositoryManager.SubscriptionRepository.GetSubscriptions(subscriptionParameters, trackChange);
			var subscriptionDto = mapper.Map<IEnumerable<SubscriptionForReturnDto>>(subscriptionWithMetaData);
			return (subscriptionDto, subscriptionWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<SubscriptionForReturnDto> subscriptions, MetaData metaData)> GetSubscriptionsByUserId(SubscriptionParameters subscriptionParameters, Guid userId, bool trackChange)
		{
			var subscriptionWithMetaData = await repositoryManager.SubscriptionRepository.GetSubscriptionsByUserId(subscriptionParameters, userId, trackChange);
			var subscriptionDto = mapper.Map<IEnumerable<SubscriptionForReturnDto>>(subscriptionWithMetaData);
			return (subscriptionDto, subscriptionWithMetaData.MetaData);
		}
	}
}
