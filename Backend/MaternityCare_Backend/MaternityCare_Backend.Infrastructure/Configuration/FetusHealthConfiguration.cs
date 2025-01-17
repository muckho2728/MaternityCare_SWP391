using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class FetusHealthConfiguration : IEntityTypeConfiguration<FetusHealth>
	{
		public void Configure(EntityTypeBuilder<FetusHealth> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Week).IsRequired();
			builder.Property(x => x.HeadCircumference).IsRequired();
			builder.Property(x => x.AmnioticFluidLevel).IsRequired();
			builder.Property(x => x.CrownRumpLength).IsRequired();
			builder.Property(x => x.BiparietalDiameter).IsRequired();
			builder.Property(x => x.FemurLength).IsRequired();
			builder.Property(x => x.EstimatedFetalWeight).IsRequired();
			builder.Property(x => x.AbdominalCircumference).IsRequired();
			builder.Property(x => x.GestationalSacDiameter).IsRequired();
			builder.HasOne(x => x.Fetus).WithMany(x => x.FetusHealths).HasForeignKey(x => x.FetusId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
