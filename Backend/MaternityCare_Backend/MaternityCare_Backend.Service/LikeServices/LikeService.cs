using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.LikeServices.DTOs;

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

		public async Task CreateLike(LikeForCreationDto likeForCreationDto, CancellationToken ct = default)
		{
			var likeEntity = mapper.Map<Like>(likeForCreationDto);
			likeEntity.CreatedAt = DateTime.Now;
			repositoryManager.LikeRepository.CreateLike(likeEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteLike(Guid blogId, Guid userId, bool trackChange, CancellationToken ct = default)
		{
			var likeEntity = await repositoryManager.LikeRepository.GetLikeByBlogIdAndUserId(blogId, userId, trackChange, ct);
			repositoryManager.LikeRepository.DeleteLike(likeEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<IEnumerable<LikeForReturnDto>> GetLikesByBlogId(Guid blogId, bool trackChange, CancellationToken ct = default)
		{
			var likeEntities = await repositoryManager.LikeRepository.GetLikesByBlogId(blogId, trackChange, ct);
			return mapper.Map<IEnumerable<LikeForReturnDto>>(likeEntities);
		}

		public async Task<int> GetNumberOfLikesByBlogId(Guid blogId, bool trackChange, CancellationToken ct = default)
		{
			return (await repositoryManager.LikeRepository.GetLikesByBlogId(blogId, trackChange, ct)).Count();
		}
	}
}
