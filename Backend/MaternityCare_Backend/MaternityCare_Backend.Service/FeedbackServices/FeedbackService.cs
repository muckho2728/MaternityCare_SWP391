using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FeedbackServices.DTOs;

namespace MaternityCare_Backend.Service.FeedbackServices
{
	internal sealed class FeedbackService : IFeedbackService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public FeedbackService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		private async Task<Feedback?> CheckFeedbackExist(Guid feedbackId, bool trackChange, CancellationToken ct = default)
		{
			var feedback = await repositoryManager.FeedbackRepository.GetFeedbackById(feedbackId, trackChange, ct);
			if (feedback == null) throw new FeedbackNotFoundException();
			return feedback;
		}
		public async Task<FeedbackForReturnDto> CreateFeedback(FeedbackForCreationDto feedbackForCreationDto, CancellationToken ct = default)
		{
			var feedbackEntity = mapper.Map<Feedback>(feedbackForCreationDto);
			feedbackEntity.CreatedAt = DateTime.Now;
			repositoryManager.FeedbackRepository.CreateFeedback(feedbackEntity);
			await repositoryManager.SaveAsync(ct);
			return mapper.Map<FeedbackForReturnDto>(feedbackEntity);
		}

		public async Task<FeedbackForReturnDto?> GetFeedbackById(Guid id, bool trackChange, CancellationToken ct = default)
		{
			var feedbackEntity = await CheckFeedbackExist(id, trackChange, ct);
			return mapper.Map<FeedbackForReturnDto>(feedbackEntity);
		}

		public async Task<(IEnumerable<FeedbackForReturnDto> feedbacks, MetaData metaData)> GetFeedbacks(FeedbackParameters feedbackParameters, bool trackChange, CancellationToken ct = default)
		{
			var feedbackWithMetaData = await repositoryManager.FeedbackRepository.GetFeedbacks(feedbackParameters, trackChange, ct);
			var feedbackDto = mapper.Map<IEnumerable<FeedbackForReturnDto>>(feedbackWithMetaData);
			return (feedbackDto, feedbackWithMetaData.MetaData);

		}
	}
}
