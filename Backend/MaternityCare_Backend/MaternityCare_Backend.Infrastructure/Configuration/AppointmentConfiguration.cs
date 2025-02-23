using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
	{
		public void Configure(EntityTypeBuilder<Appointment> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.UserId).IsRequired();
			builder.Property(x => x.SlotId).IsRequired();
			builder.Property(x => x.CreatedAt).IsRequired();
			builder.HasIndex(x => x.SlotId).IsUnique();
			builder.HasOne(x => x.User).WithMany(x => x.Appointments).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Slot).WithOne(x => x.Appointment).HasForeignKey<Appointment>(x => x.SlotId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
