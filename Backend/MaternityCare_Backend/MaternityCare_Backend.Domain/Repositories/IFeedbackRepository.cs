using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IFeedbackRepository
	{
		Task<PagedList<Feedback>> GetFeedbacks(FeedbackParameters feedbackParameters, bool trackChange, CancellationToken ct = default);
		Task<Feedback?> GetFeedbackById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateFeedback(Feedback feedback);
	}
}
