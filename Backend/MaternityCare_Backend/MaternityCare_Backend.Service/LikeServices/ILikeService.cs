﻿using MaternityCare_Backend.Service.LikeServices.DTOs;

namespace MaternityCare_Backend.Service.LikeServices
{
	public interface ILikeService
	{
		Task CreateLike(Guid blogId, Guid userId, CancellationToken ct = default);
		Task DeleteLike(Guid blogId, Guid userId, CancellationToken ct = default);
		Task<IEnumerable<LikeForReturnDto>> GetLikesByBlogId(Guid blogId, CancellationToken ct = default);
		Task<bool> IsLikedByUser(Guid blogId, Guid userId, CancellationToken ct = default);
		Task<int> GetNumberOfLikesByBlogId(Guid blogId, CancellationToken ct = default);
	}
}
