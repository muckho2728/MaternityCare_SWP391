using AutoMapper;
using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Domain.RequestFeatures;
using MaternityCare_Backend.Service.CommentServices.DTOs;

namespace MaternityCare_Backend.Service.CommentServices
{
	internal sealed class CommentService : ICommentService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public CommentService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		private async Task<Comment?> CheckCommentExist(Guid commentId, bool trackChange, CancellationToken ct = default)
		{
			var commentEntity = await repositoryManager.CommentRepository.GetComment(commentId, trackChange, ct);
			if (commentEntity == null) throw new CommentNotFoundException();
			return commentEntity;
		}

		public async Task CreateComment(CommentForCreationDto commentForCreationDto, CancellationToken ct = default)
		{
			var commentEntity = mapper.Map<Comment>(commentForCreationDto);
			commentEntity.CreatedAt = DateTime.Now;
			repositoryManager.CommentRepository.CreateComment(commentEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteComment(Guid commentId, bool trackChange, CancellationToken ct = default)
		{
			var commentEntity = await CheckCommentExist(commentId, trackChange, ct);
			repositoryManager.CommentRepository.DeleteComment(commentEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<CommentForReturnDto> comments, MetaData metaData)> GetCommentsByBlogId(CommentParameters commentParameters, Guid blogId, bool trackChange, CancellationToken ct = default)
		{
			var commentsWithMetaData = await repositoryManager.CommentRepository.GetCommentsByBlogId(commentParameters, blogId, trackChange, ct);
			var comments = mapper.Map<IEnumerable<CommentForReturnDto>>(commentsWithMetaData);
			return (comments, commentsWithMetaData.MetaData);
		}

		public async Task UpdateComment(Guid commentId, CommentForUpdateDto commentForUpdateDto, bool trackChange, CancellationToken ct = default)
		{
			var commentEntity = await CheckCommentExist(commentId, trackChange, ct);
			mapper.Map(commentForUpdateDto, commentEntity);
			commentEntity.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
