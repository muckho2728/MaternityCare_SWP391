using MaternityCare_Backend.Domain.Entities;
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
			builder.Property(x => x.Type).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Feature).IsRequired().HasMaxLength(100);
			builder.Property(x => x.Price).IsRequired();
			builder.Property(x => x.Duration).IsRequired();
			builder.HasMany(x => x.Subscriptions).WithOne(x => x.Package).HasForeignKey(x => x.PackageId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
