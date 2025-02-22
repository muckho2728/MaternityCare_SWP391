using MaternityCare_Backend.Service.StandardFetusHealthServices.DTOs;

namespace MaternityCare_Backend.Service.StandardFetusHealthServices
{
	public interface IStandardFetusHealthService
	{
		Task<IEnumerable<StandardFetusHealthForReturnDto>> GetStandardFetusHealths(CancellationToken ct);
		Task<StandardFetusHealthForReturnDto?> GetStandardFetusHealth(int week, CancellationToken ct);
	}
}
