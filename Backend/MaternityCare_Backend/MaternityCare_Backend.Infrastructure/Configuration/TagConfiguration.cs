using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class TagConfiguration : IEntityTypeConfiguration<Tag>
	{
		public void Configure(EntityTypeBuilder<Tag> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
			builder.HasMany(x => x.Blogs).WithOne(x => x.Tag).HasForeignKey(c => c.TagId).OnDelete(DeleteBehavior.NoAction);

			builder.HasData(
				new Tag
				{
					Id = Guid.Parse("d5aefed2-5df7-4d2f-bec4-7932da2849de"),
					Name = "Baby"
				},
				new Tag
				{
					Id = Guid.Parse("d1a17f1e-eb54-43bc-bdac-ca1873c99362"),
					Name = "Pregnancy"
				},
				new Tag
				{
					Id = Guid.Parse("05ac02ec-3fd0-47ad-ab14-4a969bec6e3d"),
					Name = "Parenting"
				},
				new Tag
				{
					Id = Guid.Parse("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd"),
					Name = "Health"
				},
				new Tag
				{
					Id = Guid.Parse("bc557eef-49f8-4bca-8f0a-9700b8c13e7e"),
					Name = "Nutrition"
				},
				new Tag
				{
					Id = Guid.Parse("8e18a540-ce22-46d3-ba7b-cde9d20dca38"),
					Name = "Exercise"
				},
				new Tag
				{
					Id = Guid.Parse("3185dbf9-c4be-4c0e-b8e6-4d9ee47bb296"),
					Name = "Mental Health"
				}

			);
		}
	}
}
