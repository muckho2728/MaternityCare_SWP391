using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.LikeServices.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/likes")]
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
		public async Task<IActionResult> AddLike([FromForm] LikeForCreationDto likeDto, CancellationToken ct = default)
		{
			await serviceManager.LikeService.CreateLike(likeDto, ct);
			return StatusCode(201);
		}

		[HttpDelete("{blogId:guid}/{userId:guid}")]
		[Authorize]
		public async Task<IActionResult> DeleteLike([FromRoute] Guid blogId, [FromRoute] Guid userId, CancellationToken ct = default)
		{
			await serviceManager.LikeService.DeleteLike(blogId, userId, false, ct);
			return NoContent();
		}

		[HttpGet("{blogId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetLikesByBlogId([FromRoute] Guid blogId, CancellationToken ct = default)
		{
			var likes = await serviceManager.LikeService.GetLikesByBlogId(blogId, false, ct);
			return Ok(likes);
		}

		[HttpGet("{blogId:guid}/number-of-likes")]
		[Authorize]
		public async Task<IActionResult> GetNumberOfLikesByBlogId([FromRoute] Guid blogId, CancellationToken ct = default)
		{
			var numberOfLikes = await serviceManager.LikeService.GetNumberOfLikesByBlogId(blogId, false, ct);
			return Ok(numberOfLikes);
		}


	}
}
