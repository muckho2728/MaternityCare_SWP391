using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
	{
		public FeedbackRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateFeedback(Feedback feedback) => Create(feedback);

		public async Task<Feedback?> GetFeedbackById(Guid id, bool trackChange) => await FindByCondition(f => f.Id == id, trackChange).SingleOrDefaultAsync();

		public async Task<PagedList<Feedback>> GetFeedbacks(FeedbackParameters feedbackParameters, bool trackChange)
		{
			var feedbackEntities = FindAll(trackChange)
				.OrderByDescending(c => c.CreatedAt);
			return await PagedList<Feedback>.ToPagedList(feedbackEntities, feedbackParameters.PageNumber, feedbackParameters.PageSize);
		}
	}
}
