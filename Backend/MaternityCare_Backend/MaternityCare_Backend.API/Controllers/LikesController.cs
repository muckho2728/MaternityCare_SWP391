using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class LikesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public LikesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("blogs/{blogId:guid}/users/{userId:guid}/likes")]
		[Authorize]
		public async Task<IActionResult> AddLike([FromRoute] Guid blogId, [FromRoute] Guid userId, CancellationToken ct)
		{
			await serviceManager.LikeService.CreateLike(blogId, userId, ct);
			return StatusCode(201);
		}

		[HttpDelete("blogs/{blogId:guid}/users/{userId:guid}/likes")]
		[Authorize]
		public async Task<IActionResult> DeleteLike([FromRoute] Guid blogId, [FromRoute] Guid userId, CancellationToken ct)
		{
			await serviceManager.LikeService.DeleteLike(blogId, userId, ct);
			return NoContent();
		}

		[HttpGet("blogs/{blogId:guid}/number-of-likes")]
		[Authorize]
		public async Task<IActionResult> GetNumberOfLikesByBlogId([FromRoute] Guid blogId, CancellationToken ct)
		{
			var numberOfLikes = await serviceManager.LikeService.GetNumberOfLikesByBlogId(blogId, ct);
			return Ok(numberOfLikes);
		}

		[HttpGet("blogs/{blogId:guid}/likes/{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetLikeByBlogIdAndUserId([FromRoute] Guid blogId, [FromRoute] Guid userId, CancellationToken ct)
		{
			var islikeD = await serviceManager.LikeService.IsLikedByUser(blogId, userId, ct);
			return Ok(islikeD);
		}

	}
}
