using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.BlogServices.DTOs;

namespace MaternityCare_Backend.Service.BlogServices
{
	public interface IBlogService
	{
		Task CreateBlog(BlogForCreationDto blogForCreationDto, CancellationToken ct = default);
		Task UpdateBlog(Guid blogId, BlogForUpdateDto blogForUpdateDto, CancellationToken ct = default);
		Task DeleteBlog(Guid blogId, CancellationToken ct = default);
		Task<BlogForReturnDto> GetBlog(Guid blogId, CancellationToken ct = default);
		Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetBlogs(BlogParameters blogParameters, CancellationToken ct = default);
		Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetActiveBlogs(BlogParameters blogParameters, CancellationToken ct = default);
		Task ActivateBlog(Guid blogId, CancellationToken ct = default);

	}
}
