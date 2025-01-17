using MaternityCare_Backend.Domain.Constants;
using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Name).HasConversion<string>().IsRequired().HasMaxLength(10);
			builder.HasMany(x => x.Users).WithOne(x => x.Role).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.Cascade);
			builder.HasData(
				new Role
				{
					Id = new Guid("825fe2a6-c543-49cb-9d84-1f8cf2864047"),
					Name = Roles.Admin.ToString()
				},
				new Role
				{
					Id = new Guid("416b6528-8c94-4ddc-8413-012b8ee38ae4"),
					Name = Roles.Member.ToString()
				}
			);
		}
	}
}
