using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;

namespace MaternityCare_Backend.Service.SlotServices
{
	internal sealed class SlotService : ISlotService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public SlotService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
	}
}
