﻿using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class PackageConfiguration : IEntityTypeConfiguration<Package>
	{
		public void Configure(EntityTypeBuilder<Package> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Type).IsRequired().HasMaxLength(50).HasColumnType("NVARCHAR(MAX)");
			builder.Property(x => x.Feature).IsRequired().HasMaxLength(100).HasColumnType("NVARCHAR(MAX)");
			builder.Property(x => x.Price).IsRequired();
			builder.Property(x => x.Duration).IsRequired();
			builder.Property(x => x.IsDeleted).IsRequired();
			builder.Property(x => x.CreatedAt).IsRequired();
			builder.Property(x => x.UpdatedAt).IsRequired(false);
			builder.Property(x => x.DeletedAt).IsRequired(false);
			builder.HasMany(x => x.Subscriptions).WithOne(x => x.Package).HasForeignKey(x => x.PackageId).OnDelete(DeleteBehavior.NoAction);

			builder.HasData(
				new Package
				{
					Id = Guid.Parse("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
					Type = "Miễn phí",
					Feature = "Thích và bình luận các bài đăng",
					Price = 0,
					Duration = 0,
					IsDeleted = false,
					CreatedAt = DateTime.Now
				},
				new Package
				{
					Id = Guid.Parse("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
					Type = "Premium",
					Feature = "Tất cả chức năng của miễn phí;Tạo biểu đồ;Đặt lịch hẹn với bác sĩ;Thêm nhận xét về trang",
					Price = 200000,
					Duration = 10,
					IsDeleted = false,
					CreatedAt = DateTime.Now
				}
			);
		}
	}
}
