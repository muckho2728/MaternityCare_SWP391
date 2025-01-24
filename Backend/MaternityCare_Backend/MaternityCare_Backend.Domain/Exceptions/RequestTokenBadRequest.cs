namespace MaternityCare_Backend.Domain.Exceptions
{
	public sealed class RequestTokenBadRequest : BadRequestException
	{
		public RequestTokenBadRequest() : base("Invalid request. The token has some invalid values.")
		{
		}
	}
}
