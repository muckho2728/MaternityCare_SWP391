using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class SlotConfiguration : IEntityTypeConfiguration<Slot>
	{
		public void Configure(EntityTypeBuilder<Slot> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.DoctorId).IsRequired();
			builder.Property(x => x.Date).IsRequired();
			builder.Property(x => x.StartTime).IsRequired();
			builder.Property(x => x.EndTime).IsRequired();
			builder.HasOne(x => x.Doctor).WithMany(x => x.Slots).HasForeignKey(x => x.DoctorId).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Appointment).WithOne(x => x.Slot).HasForeignKey<Appointment>(x => x.SlotId).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
