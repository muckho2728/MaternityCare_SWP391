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
			builder.HasOne(x => x.Appointment).WithOne(x => x.Slot).HasForeignKey<Appointment>(x => x.SlotId).OnDelete(DeleteBehavior.NoAction);

			//Lam Viet Trung
			builder.HasData(
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				}
			);

			// Le Thi Minh Hong
			builder.HasData(
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 3, 31),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 3),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 7),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Date = new DateOnly(2025, 4, 10),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				}
			);

			// Nguyen Thi Thu Ha
			builder.HasData(
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				}
			);

			// Vo Duc Hieu
			builder.HasData(
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 1),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 4),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 8),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(10, 0),
					EndTime = new TimeOnly(10, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(10, 30),
					EndTime = new TimeOnly(11, 0),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(13, 0),
					EndTime = new TimeOnly(13, 30),
					IsBooked = false
				},
				new Slot
				{
					Id = Guid.NewGuid(),
					DoctorId = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Date = new DateOnly(2025, 4, 11),
					StartTime = new TimeOnly(13, 30),
					EndTime = new TimeOnly(14, 00),
					IsBooked = false
				}
			);
		}
	}
}
