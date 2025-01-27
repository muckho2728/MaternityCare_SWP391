using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface ITransactionRepository
	{
		void CreateTransaction(Transaction transaction);
		Task<PagedList<Transaction>> GetTransactions(TransactionParameters transactionParameters, bool trackChange);
		Task<PagedList<Transaction>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange);
		Task<Transaction?> GetTransaction(Guid transactionId, bool trackChange);

	}
}
