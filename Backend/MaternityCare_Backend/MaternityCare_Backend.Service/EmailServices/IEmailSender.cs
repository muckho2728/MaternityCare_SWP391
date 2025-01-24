using MaternityCare_Backend.Service.EmailServices.DTOs;

namespace MaternityCare_Backend.Service.EmailServices
{
	public interface IEmailSender
	{
		void SendEmail(Mail mail);
	}
}
