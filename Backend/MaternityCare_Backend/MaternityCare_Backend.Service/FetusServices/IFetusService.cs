using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.FetusServices.DTOs;

namespace MaternityCare_Backend.Service.FetusServices
{
	public interface IFetusService
	{
		Task CreateFetus(Guid userId, FetusForCreationDto fetusForCreationDto, CancellationToken ct);
		Task<(IEnumerable<FetusForReturnDto> fetuses, MetaData metaData)> GetFetusesByUserId(FetusParameters fetusParameters, Guid userId, CancellationToken ct = default);
		Task UpdateFetus(Guid fetusId, FetusForUpdateDto fetusForUpdateDto, CancellationToken ct);
	}
}
