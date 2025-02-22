using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/blogs/{blogId:guid}/users/{userId:guid}/likes")]
	[ApiController]
	public class LikesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public LikesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> AddLike([FromRoute] Guid blogId, [FromRoute] Guid userId, CancellationToken ct)
		{
			await serviceManager.LikeService.CreateLike(blogId, userId, ct);
			return StatusCode(201);
		}

		[HttpDelete]
		[Authorize]
		public async Task<IActionResult> DeleteLike([FromRoute] Guid blogId, [FromRoute] Guid userId, CancellationToken ct)
		{
			await serviceManager.LikeService.DeleteLike(blogId, userId, ct);
			return NoContent();
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetLikesByBlogId([FromRoute] Guid blogId, CancellationToken ct)
		{
			var likes = await serviceManager.LikeService.GetLikesByBlogId(blogId, ct);
			return Ok(likes);
		}

		[HttpGet("number-of-likes")]
		[Authorize]
		public async Task<IActionResult> GetNumberOfLikesByBlogId([FromRoute] Guid blogId, CancellationToken ct)
		{
			var numberOfLikes = await serviceManager.LikeService.GetNumberOfLikesByBlogId(blogId, ct);
			return Ok(numberOfLikes);
		}


	}
}
