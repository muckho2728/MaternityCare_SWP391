using MaternityCare_Backend.Service.TagServices.DTOs;

namespace MaternityCare_Backend.Service.TagServices
{
	public interface ITagService
	{
		Task<IEnumerable<TagForReturnDto>> GetTags(CancellationToken ct = default);
		Task<TagForReturnDto> GetTag(Guid tagId, CancellationToken ct = default);
	}
}
