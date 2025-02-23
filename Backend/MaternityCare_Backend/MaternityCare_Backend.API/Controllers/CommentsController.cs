using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.CommentServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class CommentsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public CommentsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("blogs/{blogId:guid}/comments")]
		[Authorize]
		public async Task<IActionResult> GetCommentsByBlogId([FromQuery] CommentParameters commentParameters, [FromRoute] Guid blogId, CancellationToken ct)
		{
			var pagedResult = await serviceManager.CommentService.GetCommentsByBlogId(commentParameters, blogId, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.comments);
		}

		[HttpPost("blogs/{blogId:guid}/users/{userId:guid}/comments")]
		[Authorize]
		public async Task<IActionResult> CreateComment([FromRoute] Guid blogId, [FromRoute] Guid userId, [FromBody] CommentForCreationDto commentForCreationDto, CancellationToken ct)
		{
			await serviceManager.CommentService.CreateComment(blogId, userId, commentForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("users/{userId:guid}/comments/{commentId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdateComment([FromRoute] Guid userId, [FromRoute] Guid commentId, [FromBody] CommentForUpdateDto commentForUpdateDto, CancellationToken ct)
		{
			await serviceManager.CommentService.UpdateComment(userId, commentId, commentForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("users/{userId:guid}/comments/{commentId:guid}")]
		[Authorize]
		public async Task<IActionResult> DeleteComment([FromRoute] Guid userId, [FromRoute] Guid commentId, CancellationToken ct)
		{
			await serviceManager.CommentService.DeleteComment(userId, commentId, ct);
			return NoContent();
		}
	}
}
