namespace MaternityCare_Backend.Domain.Exceptions
{
	public class RequestTokenBadRequest : BadRequestException
	{
		public RequestTokenBadRequest() : base("Invalid client request. The token has some invalid values.")
		{
		}
	}
}
