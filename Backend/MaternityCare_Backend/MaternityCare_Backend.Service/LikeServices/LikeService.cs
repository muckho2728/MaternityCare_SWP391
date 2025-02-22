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

		public async Task CreateLike(Guid blogId, Guid userId, CancellationToken ct = default)
		{
			var likeEntity = new Like
			{
				UserId = userId,
				BlogId = blogId,
				CreatedAt = DateTime.Now
			};
			repositoryManager.LikeRepository.CreateLike(likeEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteLike(Guid blogId, Guid userId, CancellationToken ct = default)
		{
			var likeEntity = await repositoryManager.LikeRepository.GetLikeByBlogIdAndUserId(blogId, userId, false, ct);
			repositoryManager.LikeRepository.DeleteLike(likeEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<IEnumerable<LikeForReturnDto>> GetLikesByBlogId(Guid blogId, CancellationToken ct = default)
		{
			var likeEntities = await repositoryManager.LikeRepository.GetLikesByBlogId(blogId, false, ct);
			return mapper.Map<IEnumerable<LikeForReturnDto>>(likeEntities);
		}

		public async Task<int> GetNumberOfLikesByBlogId(Guid blogId, CancellationToken ct = default)
		{
			return (await repositoryManager.LikeRepository.GetLikesByBlogId(blogId, false, ct)).Count();
		}
	}
}
