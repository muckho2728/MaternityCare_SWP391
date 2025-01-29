using MaternityCare_Backend.Service.IServices;
using MaternityCare_Backend.Service.LikeServices.DTOs;
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
		public async Task<IActionResult> AddLike([FromForm] LikeForCreationDto likeDto)
		{
			await serviceManager.LikeService.CreateLike(likeDto);
			return StatusCode(201);
		}

		[HttpDelete("{blogId:guid}/{userId:guid}")]
		public async Task<IActionResult> DeleteLike([FromRoute] Guid blogId, [FromRoute] Guid userId)
		{
			await serviceManager.LikeService.DeleteLike(blogId, userId, false);
			return NoContent();
		}

		[HttpGet("{blogId:guid}")]
		public async Task<IActionResult> GetLikesByBlogId([FromRoute] Guid blogId)
		{
			var likes = await serviceManager.LikeService.GetLikesByBlogId(blogId, false);
			return Ok(likes);
		}

		[HttpGet("{blogId:guid}/number-of-likes")]
		public async Task<IActionResult> GetNumberOfLikesByBlogId([FromRoute] Guid blogId)
		{
			var numberOfLikes = await serviceManager.LikeService.GetNumberOfLikesByBlogId(blogId, false);
			return Ok(numberOfLikes);
		}


	}
}
