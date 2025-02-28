using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusHealthServices.DTOs;
using MaternityCare_Backend.Service.ReminderServices.DTOs;
using MaternityCare_Backend.Service.StandardFetusHealthServices.DTOs;

namespace MaternityCare_Backend.Service.FetusHealthServices
{
	public interface IFetusHealthService
	{
		Task<(FetusHealthForReturnDto fetusHealth, StandardFetusHealthForReturnDto standardFetusHealth, ReminderForReturnDto reminder)> CreateFetusHealth(Guid fetusId, FetusHealthForCreationDto fetusHealthForCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<FetusHealthForReturnDto> fetusHealths, MetaData metaData)> GetFetusHealthByFetusId(FetusHealthParameters fetusHealthParameters, Guid fetusId, CancellationToken ct = default);
		Task<(FetusHealthForReturnDto fetusHealth, StandardFetusHealthForReturnDto standardFetusHealth, ReminderForReturnDto reminder)> GetFetusHealthByFetusIdAndWeek(Guid fetusId, int week, CancellationToken ct = default);
		Task UpdateFetusHealth(Guid fetusId, int week, FetusHealthForUpdateDto fetusHealthForUpdateDto, CancellationToken ct = default);
	}
}
