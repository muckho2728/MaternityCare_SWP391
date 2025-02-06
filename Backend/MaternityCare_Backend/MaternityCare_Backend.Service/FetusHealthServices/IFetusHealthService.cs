using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusHealthServices.DTOs;
using MaternityCare_Backend.Service.ReminderServices.DTOs;
using MaternityCare_Backend.Service.StandardFetusHealthServices.DTOs;

namespace MaternityCare_Backend.Service.FetusHealthServices
{
	public interface IFetusHealthService
	{
		Task<(StandardFetusHealthForReturnDto standardFetusHealth, ReminderForReturnDto reminder)> CreateFetusHealth(FetusHealthForCreationDto fetusHealthForCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<FetusHealthForReturnDto> fetusHealths, MetaData metaData)> GetFetusHealthByFetusId(FetusHealthParameters fetusHealthParameters, Guid fetusId, bool trackChange, CancellationToken ct = default);
	}
}
