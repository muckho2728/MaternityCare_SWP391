﻿using MaternityCare_Backend.Domain.Entities;
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

		public async Task<Feedback?> GetFeedbackById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(f => f.Id == id, trackChange).Include(f => f.User).SingleOrDefaultAsync(ct);

		public async Task<PagedList<Feedback>> GetFeedbacks(FeedbackParameters feedbackParameters, bool trackChange, CancellationToken ct = default)
		{
			var feedbackEntities = FindAll(trackChange)
				.Include(f => f.User)
				.OrderByDescending(c => c.CreatedAt);
			return await PagedList<Feedback>.ToPagedList(feedbackEntities, feedbackParameters.PageNumber, feedbackParameters.PageSize, ct);
		}
	}
}
