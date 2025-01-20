using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class FetusConfiguration : IEntityTypeConfiguration<Fetus>
	{
		public void Configure(EntityTypeBuilder<Fetus> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.DueDate).IsRequired();
			builder.Property(x => x.ConceptionDate).IsRequired();
			builder.Property(x => x.UserId).IsRequired();
			builder.Property(x => x.CreatedAt).IsRequired().HasDefaultValue(DateTime.Now);
			builder.Property(x => x.UpdatedAt).IsRequired(false);
			builder.HasOne(x => x.User).WithMany(x => x.Fetus).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.FetusHealths).WithOne(x => x.Fetus).HasForeignKey(x => x.FetusId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
