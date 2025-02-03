using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IStandardFetusHealthRepository
	{
		Task<IEnumerable<StandardFetusHealth>> GetStandardFetusHealths(bool trackChange, CancellationToken ct);
		Task<StandardFetusHealth?> GetStandardFetusHealth(int week, bool trackChange, CancellationToken ct);
	}
}
