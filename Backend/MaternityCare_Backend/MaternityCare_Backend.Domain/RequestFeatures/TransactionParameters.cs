using MaternityCare_Backend.Domain.Constants;

namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class TransactionParameters : RequestParameters
	{
		public TransactionStatus Status { get; set; } = TransactionStatus.Success;
	}
}
