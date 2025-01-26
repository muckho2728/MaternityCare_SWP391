using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IFeedbackRepository
	{
		Task<PagedList<Feedback>> GetFeedbacks(FeedbackParameters feedbackParameters, bool trackChange);
		Task<Feedback?> GetFeedbackById(Guid id, bool trackChange);
		void CreateFeedback(Feedback feedback);
	}
}
