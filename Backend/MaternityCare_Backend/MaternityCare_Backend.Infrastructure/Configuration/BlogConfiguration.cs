using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class BlogConfiguration : IEntityTypeConfiguration<Blog>
	{
		public void Configure(EntityTypeBuilder<Blog> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Title).IsRequired().HasMaxLength(200).HasColumnType("NVARCHAR(MAX)");
			builder.Property(x => x.Content).IsRequired().HasColumnType("NVARCHAR(MAX)");
			builder.Property(x => x.Image).IsRequired(false);
			builder.Property(x => x.CreatedAt).IsRequired();
			builder.Property(x => x.UpdatedAt).IsRequired(false);
			builder.Property(x => x.UserId).IsRequired();
			builder.Property(x => x.IsActive).IsRequired();
			builder.HasOne(x => x.User).WithMany(x => x.Blogs).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Comments).WithOne(x => x.Blog).HasForeignKey(x => x.BlogId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Likes).WithOne(x => x.Blog).HasForeignKey(x => x.BlogId).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Tag).WithMany(x => x.Blogs).HasForeignKey(x => x.TagId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
