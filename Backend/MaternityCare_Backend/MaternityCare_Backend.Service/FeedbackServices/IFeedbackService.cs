﻿using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FeedbackServices.DTOs;

namespace MaternityCare_Backend.Service.FeedbackServices
{
	public interface IFeedbackService
	{
		Task<FeedbackForReturnDto> CreateFeedback(FeedbackForCreationDto feedbackForCreationDto, CancellationToken ct = default);
		Task<FeedbackForReturnDto?> GetFeedbackById(Guid id, CancellationToken ct = default);
		Task<(IEnumerable<FeedbackForReturnDto> feedbacks, MetaData metaData)> GetFeedbacks(FeedbackParameters feedbackParameters, CancellationToken ct = default);
	}
}
