using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class ReminderConfiguration : IEntityTypeConfiguration<Reminder>
	{
		public void Configure(EntityTypeBuilder<Reminder> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Week).IsRequired();
			builder.Property(x => x.Description).IsRequired();
		}
	}
}
