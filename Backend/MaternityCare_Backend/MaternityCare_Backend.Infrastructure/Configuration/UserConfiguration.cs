using MaternityCare_Backend.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		private readonly IPasswordHasher<User> passwordHasher;

		public UserConfiguration(IPasswordHasher<User> passwordHasher)
		{
			this.passwordHasher = passwordHasher;
		}
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.FullName).IsRequired().HasMaxLength(100).HasColumnType("NVARCHAR(MAX)");
			builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
			builder.HasIndex(x => x.Email).IsUnique();
			builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
			builder.HasIndex(x => x.Username).IsUnique();
			builder.Property(x => x.Password).IsRequired();
			builder.Property(x => x.DateOfBirth).IsRequired();
			builder.Property(x => x.Avatar).IsRequired();
			builder.Property(x => x.CCCD).IsRequired().HasMaxLength(12);
			builder.Property(x => x.IsEmailConfirmed);
			builder.Property(x => x.RoleId).IsRequired();
			builder.Property(x => x.IsActive);
			builder.Property(x => x.CreatedAt);
			builder.Property(x => x.UpdatedAt);
			builder.Property(x => x.EmailConfirmationToken);
			builder.Property(x => x.PasswordResetToken);
			builder.Property(x => x.PasswordResetTokenExpiryTime);
			builder.Property(x => x.RefreshToken);
			builder.Property(x => x.RefreshTokenExpiryTime);
			builder.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Blogs).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Comments).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Likes).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Feedbacks).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Fetus).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Appointments).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Subscriptions).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);

			var admin = new User
			{
				Id = Guid.Parse("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
				FullName = "Admin",
				Email = "admin@gmail.com",
				Username = "admin",
				DateOfBirth = new DateOnly(2002, 1, 23),
				Avatar = "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=",
				CCCD = "123456789012",
				RoleId = Guid.Parse("825fe2a6-c543-49cb-9d84-1f8cf2864047"),
				IsActive = true,
				CreatedAt = DateTime.Now,
				IsEmailConfirmed = true
			};
			admin.Password = passwordHasher.HashPassword(admin, "admin");

			var user = new User
			{
				Id = Guid.Parse("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
				FullName = "Nguyen Le Tan Nghiep",
				Email = "tannghiepnguyen123@gmail.com",
				Username = "tannghiep",
				DateOfBirth = new DateOnly(2002, 1, 23),
				Avatar = "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=",
				CCCD = "082202000012",
				RoleId = Guid.Parse("416b6528-8c94-4ddc-8413-012b8ee38ae4"),
				IsActive = true,
				CreatedAt = DateTime.Now,
				IsEmailConfirmed = true
			};
			user.Password = passwordHasher.HashPassword(user, "tannghiep");
			builder.HasData(admin, user);
		}
	}
}
