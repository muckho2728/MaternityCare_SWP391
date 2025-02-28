using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.BlogServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class BlogsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public BlogsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("blogs")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> GetBlogs([FromQuery] BlogParameters blogParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.BlogService.GetBlogs(blogParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.blogs);
		}

		[HttpGet("{blogId:guid}")]
		public async Task<IActionResult> GetBlog([FromRoute] Guid blogId, CancellationToken ct)
		{
			var blog = await serviceManager.BlogService.GetBlog(blogId, ct);
			return Ok(blog);
		}

		[HttpPost("users/{userId:guid}/blogs")]
		[Authorize]
		public async Task<IActionResult> CreateBlog([FromRoute] Guid userId, [FromForm] BlogForCreationDto blogForCreationDto, CancellationToken ct)
		{
			await serviceManager.BlogService.CreateBlog(userId, blogForCreationDto, ct);
			return StatusCode(201, "Blog created successfully");
		}

		[HttpPut("users/{userId:guid}/blogs/{blogId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdateBlog([FromRoute] Guid userId, [FromRoute] Guid blogId, [FromForm] BlogForUpdateDto blogForUpdateDto, CancellationToken ct)
		{
			await serviceManager.BlogService.UpdateBlog(userId, blogId, blogForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("users/{userId:guid}/blogs/{blogId:guid}")]
		[Authorize]
		public async Task<IActionResult> DeleteBlog([FromRoute] Guid userId, [FromRoute] Guid blogId, CancellationToken ct)
		{
			await serviceManager.BlogService.DeleteBlog(userId, blogId, ct);
			return NoContent();
		}

		[HttpPut("{blogId:guid}/activation")]
		[Authorize(Roles = nameof(Roles.Admin))]
		public async Task<IActionResult> ActivateBlog([FromRoute] Guid blogId, CancellationToken ct)
		{
			await serviceManager.BlogService.ActivateBlog(blogId, ct);
			return NoContent();
		}

		[HttpGet("blogs/active-blogs")]
		public async Task<IActionResult> GetActiveBlogs([FromQuery] ActiveBlogParameters activeBlogParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.BlogService.GetActiveBlogs(activeBlogParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.blogs);
		}
	}
}
