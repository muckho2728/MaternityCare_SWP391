using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;

namespace MaternityCare_Backend.Service.AppointmentServices
{
	internal sealed class AppointmentService : IAppointmentService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public AppointmentService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
	}
}
