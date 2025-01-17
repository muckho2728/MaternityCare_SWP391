using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
	{
		public void Configure(EntityTypeBuilder<Doctor> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Avatar).IsRequired();
			builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
			builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
			builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(12);
			builder.Property(x => x.Specialization).IsRequired().HasMaxLength(100);
			builder.Property(x => x.YearsOfExperience).IsRequired();
			builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
			builder.Property(x => x.CreatedAt).IsRequired().HasDefaultValue(DateTime.Now);
			builder.Property(x => x.UpdatedAt).IsRequired(false);
			builder.Property(x => x.DeletedAt).IsRequired(false);
			builder.HasMany(x => x.Slots).WithOne(x => x.Doctor).HasForeignKey(x => x.DoctorId);
		}
	}
}
