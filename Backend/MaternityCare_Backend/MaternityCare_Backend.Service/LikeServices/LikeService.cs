using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;

namespace MaternityCare_Backend.Service.LikeServices
{
	internal sealed class LikeService : ILikeService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public LikeService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
	}
}
