using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ITransactionRepository
	{
		void CreateTransaction(Transaction transaction);
		Task<PagedList<Transaction>> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Transaction>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<Transaction?> GetTransaction(Guid transactionId, bool trackChange, CancellationToken ct = default);

	}
}
