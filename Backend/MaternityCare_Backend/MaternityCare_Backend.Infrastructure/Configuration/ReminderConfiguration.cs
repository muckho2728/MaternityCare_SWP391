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

			builder.HasData(
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 5,
					Description = "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 9,
					Description = "You should have your first-trimester screening to check for chromosomal conditions."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 13,
					Description = "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally"
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 18,
					Description = "You should have an anomaly scan to examine fetal anatomy."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 20,
					Description = "You should have the mid-pregnancy ultrasound to check the baby’s development."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 25,
					Description = "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)"
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 31,
					Description = "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 37,
					Description = "You’re now considered early term. You should have regular monitoring."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 39,
					Description = "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort."
				}
			);
		}
	}
}
