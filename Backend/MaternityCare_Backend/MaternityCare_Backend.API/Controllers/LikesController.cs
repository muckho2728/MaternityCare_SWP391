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
		public async Task<IActionResult> DeleteLike(Guid blogId, Guid userId)
		{
			await serviceManager.LikeService.DeleteLike(blogId, userId, false);
			return StatusCode(204);
		}

		[HttpGet("{blogId:guid}")]
		public async Task<IActionResult> GetLikes(Guid blogId)
		{
			var likes = await serviceManager.LikeService.GetLikesByBlogId(blogId, false);
			return Ok(likes);
		}
	}
}
