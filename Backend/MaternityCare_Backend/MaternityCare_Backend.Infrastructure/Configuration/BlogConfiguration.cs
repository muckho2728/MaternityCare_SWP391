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
					Title = "26 week already lactating",
					Content = "I’m 26 weeks exactly tomorrow but I started lactating probably 3 weeks ago. It was small spots at first but now I wake up with both nipples soaked through my shirts. My obgyn says not to worry but I would like to understand why so much so early. Any ideas?",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
					IsActive = true,
					TagId = Guid.Parse("d1a17f1e-eb54-43bc-bdac-ca1873c99362")

				},
				new Blog
				{
					Id = Guid.Parse("d53abcd4-5ad4-42cd-b5ac-c00bdbd5191c"),
					Title = "Could it be a sign of early pregnancy or pms?",
					Content = "I reached my peak of ovulation on the 8th and BD twice a day alllll month. The day after I’ve had hard super tender nips. (Which I know is usual after ovulation) ever since than my breast have my sore and my nips hurt just as bad. I don’t start my period till the 23rd and I usually pms 5 days prior. Is it possible it’s a symptom? \r\n-ive been taking vitamins and eating as healthy as possible while avoiding caffeine as well",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
					IsActive = true,
					TagId = Guid.Parse("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd")
				},
				new Blog
				{
					Id = Guid.Parse("8081a98b-ec3a-4bd2-965d-063617722541"),
					Title = "Could be implantation bleeding? anyone have a similar cycle?",
					Content = "My peak was on February 18th, and I ovulated on the 19th. My period was supposed to start on the 1st of this month. Today is March 4th, and I still haven’t gotten my period. However, I have brownish spotting when I pee and wipe, but not every time. I took a pregnancy test this morning, and it came back negative. My BBT has been at 98°F since the 28th. I had white discharge on the 2nd and 3rd. I started the brownish spotting on the morning of 12 DPO.\"",
					CreatedAt = DateTime.Now,
					UserId = Guid.Parse("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
					IsActive = true,
					TagId = Guid.Parse("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd")
				}
			);
		}
	}
}
