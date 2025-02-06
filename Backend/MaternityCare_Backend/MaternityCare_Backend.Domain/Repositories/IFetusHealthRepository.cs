using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.RequestFeatures;

namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IFetusHealthRepository
	{
		void CreateFetusHealth(FetusHealth fetusHealth);
		Task<PagedList<FetusHealth>> GetFetusHealthByFetusId(FetusHealthParameters fetusHealthParameters, Guid fetusId, bool trackChange, CancellationToken ct = default);
	}
}
