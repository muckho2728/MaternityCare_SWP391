using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
			builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
			builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Password).IsRequired();
			builder.Property(x => x.DateOfBirth).IsRequired();
			builder.Property(x => x.Avatar).IsRequired();
			builder.Property(x => x.CCCD).IsRequired().HasMaxLength(12);
			builder.Property(x => x.IsEmailConfirmed).HasDefaultValue(false);
			builder.Property(x => x.RoleId).IsRequired();
			builder.Property(x => x.IsActive).HasDefaultValue(true);
			builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.UpdatedAt);
			builder.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Blogs).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Comments).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Likes).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Feedbacks).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Fetus).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Appointments).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Subscriptions).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
