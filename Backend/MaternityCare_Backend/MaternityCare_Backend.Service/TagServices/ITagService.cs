using MaternityCare_Backend.Service.TagServices.DTOs;

namespace MaternityCare_Backend.Service.TagServices
{
	public interface ITagService
	{
		Task<IEnumerable<TagForReturnDto>> GetTags(bool trackChange, CancellationToken ct = default);
		Task<TagForReturnDto> GetTag(Guid tagId, bool trackChange, CancellationToken ct = default);
	}
}
