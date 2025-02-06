using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IFetusRepository
	{
		void CreateFetus(Fetus fetus);
		Task<PagedList<Fetus>> GetFetusByUserId(FetusParameters fetusParameters, Guid userId, bool trackChange, CancellationToken ct = default);
		Task<Fetus?> GetFetusById(Guid fetusId, bool trackChange, CancellationToken ct = default);

	}
}
