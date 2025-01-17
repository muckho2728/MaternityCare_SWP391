using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class StandardFetusHealthConfiguration : IEntityTypeConfiguration<StandardFetusHealth>
	{
		public void Configure(EntityTypeBuilder<StandardFetusHealth> builder)
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
		}
	}
}
