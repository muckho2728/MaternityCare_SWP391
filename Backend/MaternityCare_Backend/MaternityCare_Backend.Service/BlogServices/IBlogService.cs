using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.BlogServices.DTOs;

namespace MaternityCare_Backend.Service.BlogServices
{
	public interface IBlogService
	{
		Task CreateBlog(BlogForCreationDto blogForCreationDto, CancellationToken ct = default);
		Task UpdateBlog(Guid blogId, BlogForUpdateDto blogForUpdateDto, bool trackChange, CancellationToken ct = default);
		Task DeleteBlog(Guid blogId, CancellationToken ct = default);
		Task<BlogForReturnDto> GetBlog(Guid blogId, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetBlogs(BlogParameters blogParameters, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<BlogForReturnDto> blogs, MetaData metaData)> GetActiveBlogs(BlogParameters blogParameters, bool trackChange, CancellationToken ct = default);
		Task ActivateBlog(Guid blogId, bool trackChange, CancellationToken ct = default);

	}
}
