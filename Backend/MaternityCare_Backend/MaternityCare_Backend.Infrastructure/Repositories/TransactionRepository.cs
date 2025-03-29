using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Infrastructure.Extensions;
using MaternityCare_Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Repositories
{
	internal sealed class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
	{
		public TransactionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public void CreateTransaction(Transaction transaction) => Create(transaction);

		public async Task<Transaction?> GetTransaction(Guid transactionId, bool trackChange, CancellationToken ct = default) => await FindByCondition(t => t.Id == transactionId, trackChange).SingleOrDefaultAsync(ct);

		public async Task<PagedList<Transaction>> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionEntities = FindAll(trackChange)
				.Include(t => t.Subscription)
				.ThenInclude(t => t.User)
				.Filter(transactionParameters.Status)
				.Sort();

			return await PagedList<Transaction>.ToPagedList(transactionEntities, transactionParameters.PageNumber, transactionParameters.PageSize, ct);
		}

		public async Task<PagedList<Transaction>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionEntities = FindAll(trackChange)
				.Where(t => t.Subscription.UserId == userId)
				.Include(t => t.Subscription)
				.ThenInclude(t => t.User)
				.Filter(transactionParameters.Status)
				.Sort();

			return await PagedList<Transaction>.ToPagedList(transactionEntities, transactionParameters.PageNumber, transactionParameters.PageSize, ct);
		}
	}
}
