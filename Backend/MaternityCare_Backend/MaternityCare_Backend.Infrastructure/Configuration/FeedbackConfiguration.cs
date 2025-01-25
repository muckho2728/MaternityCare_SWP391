using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
	{
		public void Configure(EntityTypeBuilder<Feedback> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.UserId).IsRequired();
			builder.Property(x => x.Score).IsRequired();
			builder.Property(x => x.Content).IsRequired();
			builder.Property(x => x.CreatedAt).IsRequired();
			builder.HasOne(x => x.User).WithMany(x => x.Feedbacks).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
