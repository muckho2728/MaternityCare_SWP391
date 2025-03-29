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

			builder.HasData(
				new Blog
				{
					Id = Guid.Parse("525be099-6b93-4889-9384-e986fcd8595a"),
					Title = "26 tuần cho con bú",
					Content = "Tôi sẽ bước sang tuần thứ 26 vào đúng ngày mai nhưng tôi đã bắt đầu cho con bú có lẽ là 3 tuần trước. Lúc đầu chỉ là những đốm nhỏ nhưng giờ tôi thức dậy với cả hai núm vú ướt đẫm áo. Bác sĩ sản phụ khoa của tôi nói rằng đừng lo lắng nhưng tôi muốn hiểu tại sao lại sớm như vậy. Bạn có ý tưởng nào không?",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
					IsActive = true,
					TagId = Guid.Parse("d1a17f1e-eb54-43bc-bdac-ca1873c99362")

				},
				new Blog
				{
					Id = Guid.Parse("d53abcd4-5ad4-42cd-b5ac-c00bdbd5191c"),
					Title = "Đây có thể là dấu hiệu của việc mang thai sớm?",
					Content = "Tôi đạt đỉnh rụng trứng vào ngày 8 và BD hai lần một ngày trong suốt tháng. Ngày hôm sau, tôi bị đau núm vú cứng và siêu mềm. (Tôi biết là bình thường sau khi rụng trứng) kể từ đó ngực tôi bị đau và núm vú của tôi cũng đau như vậy. Tôi không bắt đầu kỳ kinh nguyệt cho đến ngày 23 và tôi thường có PMS 5 ngày trước đó. Có thể đó là một triệu chứng không? \r\n-tôi đã uống vitamin và ăn uống lành mạnh nhất có thể trong khi cũng tránh xa caffeine",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
					IsActive = true,
					TagId = Guid.Parse("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd")
				},
				new Blog
				{
					Id = Guid.Parse("8081a98b-ec3a-4bd2-965d-063617722541"),
					Title = "Đây có thể là chảy máu do cấy ghép tử cung? Có ai gặp phải chu kỳ tương tự không?",
					Content = "Đỉnh điểm của tôi là vào ngày 18 tháng 2 và tôi rụng trứng vào ngày 19. Kỳ kinh của tôi được cho là bắt đầu vào ngày 1 tháng này. Hôm nay là ngày 4 tháng 3 và tôi vẫn chưa có kinh. Tuy nhiên, tôi bị ra máu nâu khi đi tiểu và lau, nhưng không phải lúc nào cũng vậy. Tôi đã thử thai vào sáng nay và kết quả là âm tính. Nhiệt độ cơ thể của tôi là 98°F kể từ ngày 28. Tôi bị ra dịch trắng vào ngày 2 và ngày 3. Tôi bắt đầu ra máu nâu vào buổi sáng",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
					IsActive = true,
					TagId = Guid.Parse("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd")
				}
			);
		}
	}
}
