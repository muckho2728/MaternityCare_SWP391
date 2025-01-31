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
			builder.Property(x => x.HeadCircumference);
			builder.Property(x => x.AmnioticFluidLevel);
			builder.Property(x => x.CrownRumpLength);
			builder.Property(x => x.BiparietalDiameter);
			builder.Property(x => x.FemurLength);
			builder.Property(x => x.EstimatedFetalWeight);
			builder.Property(x => x.AbdominalCircumference);
			builder.Property(x => x.GestationalSacDiameter);
			builder.HasOne(x => x.Fetus).WithMany(x => x.FetusHealths).HasForeignKey(x => x.FetusId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
