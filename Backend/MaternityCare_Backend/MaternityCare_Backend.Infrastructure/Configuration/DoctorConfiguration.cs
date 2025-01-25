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
			builder.Property(x => x.IsDeleted).IsRequired();
			builder.Property(x => x.CreatedAt).IsRequired();
			builder.Property(x => x.UpdatedAt).IsRequired(false);
			builder.Property(x => x.DeletedAt).IsRequired(false);
			builder.HasMany(x => x.Slots).WithOne(x => x.Doctor).HasForeignKey(x => x.DoctorId);

			builder.HasData(
				new Doctor
				{
					Id = Guid.Parse("1f498837-82e7-4901-b4d6-4810f4aa1785"),
					Avatar = "https://maternitycare.blob.core.windows.net/maternitycare/LamVietTrung.jpg",
					FullName = "Lam Viet Trung",
					Email = "lamviettrung@gmail.com",
					PhoneNumber = "0457009809",
					Specialization = "Obstetrician",
					YearsOfExperience = 5,
					IsDeleted = false,
					CreatedAt = DateTime.Now,
				},
				new Doctor
				{
					Id = Guid.Parse("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
					Avatar = "https://maternitycare.blob.core.windows.net/maternitycare/LeThiMinhHong.jpg",
					FullName = "Le Thi Minh Hong",
					Email = "lethiminhhong@gmail.com",
					PhoneNumber = "0862605697",
					Specialization = "Obstetrician",
					YearsOfExperience = 3,
					IsDeleted = false,
					CreatedAt = DateTime.Now,
				},
				new Doctor
				{
					Id = Guid.Parse("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
					Avatar = "https://maternitycare.blob.core.windows.net/maternitycare/NguyenThiThuHa.jpg",
					FullName = "Nguyen Thi Thu Ha",
					Email = "nguyenthithuha@gmail.com",
					PhoneNumber = "0137746881",
					Specialization = "Obstetrician",
					YearsOfExperience = 7,
					IsDeleted = false,
					CreatedAt = DateTime.Now,
				},
				new Doctor
				{
					Id = Guid.Parse("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
					Avatar = "https://maternitycare.blob.core.windows.net/maternitycare/VoDucHieu.jpg",
					FullName = "Vo Duc Hieu",
					Email = "voduchieu@gmail.com",
					PhoneNumber = "0754559328",
					Specialization = "Obstetrician",
					YearsOfExperience = 8,
					IsDeleted = false,
					CreatedAt = DateTime.Now,
				}
			);
		}
	}
}
