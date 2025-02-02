using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Domain.RequestFeatures
{
	public class PagedList<T> : List<T>
	{
		public MetaData MetaData { get; set; }
		public PagedList(List<T> items, int count, int pageNumber, int pageSize)
		{
			MetaData = new MetaData
			{
				TotalCount = count,
				PageSize = pageSize,
				CurrentPage = pageNumber,
				TotalPages = (int)Math.Ceiling(count / (double)pageSize)
			};
			AddRange(items);
		}
		public async static Task<PagedList<T>> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize, CancellationToken ct = default)
		{
			var count = await source.CountAsync();
			var items = await source
				.Skip((pageNumber - 1) * pageSize)
				.Take(pageSize)
				.ToListAsync(ct);
			return new PagedList<T>(items, count, pageNumber, pageSize);
		}
	}
}
