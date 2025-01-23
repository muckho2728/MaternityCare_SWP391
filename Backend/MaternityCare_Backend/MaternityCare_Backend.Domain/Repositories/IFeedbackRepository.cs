using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IFeedbackRepository
	{
		public Task<PagedList<Feedback>> GetFeedbacks(FeedbackParameters feedbackParameters, bool trackChange);
		public Task<Feedback?> GetFeedbackById(Guid id, bool trackChange);
		public void CreateFeedback(Feedback feedback);
	}
}
