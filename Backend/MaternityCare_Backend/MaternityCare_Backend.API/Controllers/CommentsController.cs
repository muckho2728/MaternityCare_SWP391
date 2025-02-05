using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.CommentServices.DTOs;
using MaternityCare_Backend.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MaternityCare_Backend.API.Controllers
{
	[Route("api/comments")]
	[ApiController]
	public class CommentsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public CommentsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("{blogId:guid}")]
		[Authorize]
		public async Task<IActionResult> GetCommentsByBlogId([FromQuery] CommentParameters commentParameters, [FromRoute] Guid blogId, CancellationToken ct)
		{
			var pagedResult = await serviceManager.CommentService.GetCommentsByBlogId(commentParameters, blogId, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.comments);
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> CreateComment([FromBody] CommentForCreationDto commentForCreationDto, CancellationToken ct)
		{
			await serviceManager.CommentService.CreateComment(commentForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{commentId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdateComment([FromRoute] Guid commentId, [FromBody] CommentForUpdateDto commentForUpdateDto, CancellationToken ct)
		{
			await serviceManager.CommentService.UpdateComment(commentId, commentForUpdateDto, false, ct);
			return NoContent();
		}

		[HttpDelete("{commentId:guid}")]
		[Authorize]
		public async Task<IActionResult> DeleteComment([FromRoute] Guid commentId, CancellationToken ct)
		{
			await serviceManager.CommentService.DeleteComment(commentId, false, ct);
			return NoContent();
		}
	}
}
