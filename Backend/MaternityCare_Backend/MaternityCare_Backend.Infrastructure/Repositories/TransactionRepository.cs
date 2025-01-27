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

		public async Task<Transaction?> GetTransaction(Guid transactionId, bool trackChange) => await FindByCondition(t => t.Id == transactionId, trackChange).SingleOrDefaultAsync();

		public async Task<PagedList<Transaction>> GetTransactions(TransactionParameters transactionParameters, bool trackChange)
		{
			var transactionEntities = FindAll(trackChange)
				.Filter(transactionParameters.Status)
				.Sort();

			return await PagedList<Transaction>.ToPagedList(transactionEntities, transactionParameters.PageNumber, transactionParameters.PageSize);
		}

		public async Task<PagedList<Transaction>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange)
		{
			var transactionEntities = FindAll(trackChange)
				.Include(t => t.Subscription)
				.Where(t => t.Subscription.UserId == userId)
				.Filter(transactionParameters.Status)
				.Sort();

			return await PagedList<Transaction>.ToPagedList(transactionEntities, transactionParameters.PageNumber, transactionParameters.PageSize);
		}
	}
}
