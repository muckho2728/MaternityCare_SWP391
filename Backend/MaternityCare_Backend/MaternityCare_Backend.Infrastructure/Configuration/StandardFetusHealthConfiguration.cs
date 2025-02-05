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
			builder.Property(x => x.HeadCircumference).HasMaxLength(20);
			builder.Property(x => x.AmnioticFluidLevel).HasMaxLength(20);
			builder.Property(x => x.CrownRumpLength).HasMaxLength(20);
			builder.Property(x => x.BiparietalDiameter).HasMaxLength(20);
			builder.Property(x => x.FemurLength).HasMaxLength(20);
			builder.Property(x => x.EstimatedFetalWeight).HasMaxLength(20);
			builder.Property(x => x.AbdominalCircumference).HasMaxLength(20);
			builder.Property(x => x.GestationalSacDiameter).HasMaxLength(20);

			builder.HasData(
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 6,
					HeadCircumference = null,
					AmnioticFluidLevel = "2-3",
					CrownRumpLength = "4-9",
					BiparietalDiameter = null,
					FemurLength = null,
					EstimatedFetalWeight = null,
					AbdominalCircumference = null,
					GestationalSacDiameter = "14-25"
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 7,
					HeadCircumference = null,
					AmnioticFluidLevel = "2-3",
					CrownRumpLength = "9-14",
					BiparietalDiameter = null,
					FemurLength = null,
					EstimatedFetalWeight = null,
					AbdominalCircumference = null,
					GestationalSacDiameter = "18-30"
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 8,
					HeadCircumference = null,
					AmnioticFluidLevel = "2-3",
					CrownRumpLength = "14-22",
					BiparietalDiameter = null,
					FemurLength = null,
					EstimatedFetalWeight = null,
					AbdominalCircumference = null,
					GestationalSacDiameter = "25-35"
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 9,
					HeadCircumference = null,
					AmnioticFluidLevel = "2-3",
					CrownRumpLength = "22-31",
					BiparietalDiameter = null,
					FemurLength = null,
					EstimatedFetalWeight = null,
					AbdominalCircumference = null,
					GestationalSacDiameter = "28-36"
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 10,
					HeadCircumference = "56-78",
					AmnioticFluidLevel = "2-3",
					CrownRumpLength = "31-40",
					BiparietalDiameter = "15-22",
					FemurLength = "7-9",
					EstimatedFetalWeight = "5-8",
					AbdominalCircumference = null,
					GestationalSacDiameter = "30-40"
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 12,
					HeadCircumference = "70-85",
					AmnioticFluidLevel = "2-3",
					CrownRumpLength = "50-60",
					BiparietalDiameter = "21-24",
					FemurLength = "9-12",
					EstimatedFetalWeight = "14-19",
					AbdominalCircumference = "50-65",
					GestationalSacDiameter = "40-50"
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 14,
					HeadCircumference = "90-110",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = "78-85",
					BiparietalDiameter = "24-30",
					FemurLength = "14-17",
					EstimatedFetalWeight = "40-60",
					AbdominalCircumference = "70-85",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 16,
					HeadCircumference = "110-130",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "32-38",
					FemurLength = "18-22",
					EstimatedFetalWeight = "100-150",
					AbdominalCircumference = "90-110",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 18,
					HeadCircumference = "130-150",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "38-45",
					FemurLength = "22-27",
					EstimatedFetalWeight = "190-220",
					AbdominalCircumference = "110-130",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 20,
					HeadCircumference = "150-170",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "45-50",
					FemurLength = "30-34",
					EstimatedFetalWeight = "260-300",
					AbdominalCircumference = "125-155",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 22,
					HeadCircumference = "170-190",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "50-55",
					FemurLength = "34-38",
					EstimatedFetalWeight = "350-420",
					AbdominalCircumference = "150-180",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 24,
					HeadCircumference = "190-210",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "55-60",
					FemurLength = "38-42",
					EstimatedFetalWeight = "500-600",
					AbdominalCircumference = "170-200",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 26,
					HeadCircumference = "210-230",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "60-65",
					FemurLength = "42-47",
					EstimatedFetalWeight = "750-850",
					AbdominalCircumference = "190-220",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 28,
					HeadCircumference = "230-250",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "65-70",
					FemurLength = "47-52",
					EstimatedFetalWeight = "1000-1200",
					AbdominalCircumference = "210-250",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 30,
					HeadCircumference = "250-270",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "70-75",
					FemurLength = "52-56",
					EstimatedFetalWeight = "1400-1600",
					AbdominalCircumference = "230-270",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 32,
					HeadCircumference = "270-290",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "75-80",
					FemurLength = "56-60",
					EstimatedFetalWeight = "1700-2000",
					AbdominalCircumference = "250-290",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 34,
					HeadCircumference = "290-310",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "80-85",
					FemurLength = "60-65",
					EstimatedFetalWeight = "2100-2500",
					AbdominalCircumference = "270-310",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 36,
					HeadCircumference = "310-330",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "85-90",
					FemurLength = "65-70",
					EstimatedFetalWeight = "2500-2900",
					AbdominalCircumference = "290-330",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 38,
					HeadCircumference = "330-350",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "90-95",
					FemurLength = "70-75",
					EstimatedFetalWeight = "2900-3200",
					AbdominalCircumference = "310-350",
					GestationalSacDiameter = null
				},
				new StandardFetusHealth
				{
					Id = Guid.NewGuid(),
					Week = 40,
					HeadCircumference = "350-370",
					AmnioticFluidLevel = "2-8",
					CrownRumpLength = null,
					BiparietalDiameter = "95-100",
					FemurLength = "75-80",
					EstimatedFetalWeight = "3200-3500",
					AbdominalCircumference = "320-360",
					GestationalSacDiameter = null
				}
			);
		}
	}
}
