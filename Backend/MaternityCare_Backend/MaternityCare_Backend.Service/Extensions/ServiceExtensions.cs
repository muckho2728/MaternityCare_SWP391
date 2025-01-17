using Microsoft.Extensions.DependencyInjection;

namespace MaternityCare_Backend.Service.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureAutomapper(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(ServiceExtensions).Assembly);
		}
	}
}
