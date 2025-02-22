using AutoMapper;
using MaternityCare_Backend.Domain.Exceptions;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.TagServices.DTOs;

namespace MaternityCare_Backend.Service.TagServices
{
	internal sealed class TagService : ITagService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public TagService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task<TagForReturnDto> GetTag(Guid tagId, CancellationToken ct = default)
		{
			var tagEntity = await repositoryManager.TagRepository.GetTag(tagId, false, ct);
			if (tagEntity == null) throw new TagNotFoundException();
			return mapper.Map<TagForReturnDto>(tagEntity);
		}

		public async Task<IEnumerable<TagForReturnDto>> GetTags(CancellationToken ct = default)
		{
			var tagEntities = await repositoryManager.TagRepository.GetTags(false, ct);
			return mapper.Map<IEnumerable<TagForReturnDto>>(tagEntities);
		}
	}
}
