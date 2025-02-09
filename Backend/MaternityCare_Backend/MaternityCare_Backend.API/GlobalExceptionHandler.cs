using MaternityCare_Backend.Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MaternityCare_Backend.API
{
	public class GlobalExceptionHandler : IExceptionHandler
	{
		private readonly IProblemDetailsService problemDetailsService;

		public GlobalExceptionHandler(IProblemDetailsService problemDetailsService)
		{
			this.problemDetailsService = problemDetailsService;
		}
		public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
		{
			httpContext.Response.ContentType = "application/json";
			httpContext.Response.StatusCode = exception switch
			{
				NotFoundException => StatusCodes.Status404NotFound,
				BadRequestException => StatusCodes.Status400BadRequest,
				NotAuthenticatedException => StatusCodes.Status401Unauthorized,
				ConflictException => StatusCodes.Status409Conflict,
				_ => StatusCodes.Status500InternalServerError
			};
			var result = await problemDetailsService.TryWriteAsync(new ProblemDetailsContext
			{
				HttpContext = httpContext,
				ProblemDetails =
				{
					Title = "An error occurred",
					Status = httpContext.Response.StatusCode,
					Detail = exception.Message,
					Type = exception.GetType().Name
				},
				Exception = exception
			});
			if (!result)
			{
				await httpContext.Response.WriteAsJsonAsync(new ProblemDetails
				{
					Title = "An error occurred",
					Status = httpContext.Response.StatusCode,
					Detail = exception.Message,
					Type = exception.GetType().Name
				});
			}
			return true;
		}
	}
}
