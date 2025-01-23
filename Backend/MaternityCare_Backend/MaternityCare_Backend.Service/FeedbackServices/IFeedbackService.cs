using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FeedbackServices.DTOs;

namespace MaternityCare_Backend.Service.FeedbackServices
{
	public interface IFeedbackService
	{
		Task<FeedbackForReturnDto> CreateFeedback(FeedbackForCreationDto feedbackForCreationDto);
		Task<FeedbackForReturnDto?> GetFeedbackById(Guid id, bool trackChange);
		Task<(IEnumerable<FeedbackForReturnDto> feedbacks, MetaData metaData)> GetFeedbacks(FeedbackParameters feedbackParameters, bool trackChange);
	}
}
