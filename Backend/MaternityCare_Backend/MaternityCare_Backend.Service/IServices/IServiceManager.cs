using MaternityCare_Backend.Service.AIServices;
using MaternityCare_Backend.Service.AppointmentServices;
using MaternityCare_Backend.Service.BlogServices;
using MaternityCare_Backend.Service.CommentServices;
using MaternityCare_Backend.Service.DoctorServices;
using MaternityCare_Backend.Service.FeedbackServices;
using MaternityCare_Backend.Service.FetusHealthServices;
using MaternityCare_Backend.Service.FetusServices;
using MaternityCare_Backend.Service.LikeServices;
using MaternityCare_Backend.Service.PackageServices;
using MaternityCare_Backend.Service.ReminderServices;
using MaternityCare_Backend.Service.SlotServices;
using MaternityCare_Backend.Service.StandardFetusHealthServices;
using MaternityCare_Backend.Service.SubscriptionServices;
using MaternityCare_Backend.Service.TagServices;
using MaternityCare_Backend.Service.TransactionServices;
using MaternityCare_Backend.Service.UserServices;

namespace MaternityCare_Backend.Service.IServices
{
	public interface IServiceManager
	{
		IUserService UserService { get; }
		IFeedbackService FeedbackService { get; }
		IPackageService PackageService { get; }
		ISubscriptionService SubscriptionService { get; }
		IAppointmentService AppointmentService { get; }
		ISlotService SlotService { get; }
		ITransactionService TransactionService { get; }
		ILikeService LikeService { get; }
		IDoctorService DoctorService { get; }
		IReminderService ReminderService { get; }
		IStandardFetusHealthService StandardFetusHealthService { get; }
		ICommentService CommentService { get; }
		IFetusService FetusService { get; }
		IFetusHealthService FetusHealthService { get; }
		ITagService TagService { get; }
		IBlogService BlogService { get; }
		IAIChatService AIChatService { get; }
	}
}
