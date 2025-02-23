using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class LikeConfiguration : IEntityTypeConfiguration<Like>
	{
		public void Configure(EntityTypeBuilder<Like> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.CreatedAt);
			builder.HasIndex(x => new { x.BlogId, x.UserId }).IsUnique();
			builder.HasOne(x => x.Blog).WithMany(x => x.Likes).HasForeignKey(x => x.BlogId).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.User).WithMany(x => x.Likes).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
