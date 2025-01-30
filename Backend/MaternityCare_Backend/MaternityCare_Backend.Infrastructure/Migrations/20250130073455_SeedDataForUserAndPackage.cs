using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForUserAndPackage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 30, 14, 34, 55, 200, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 30, 14, 34, 55, 200, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 30, 14, 34, 55, 200, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 30, 14, 34, 55, 200, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Duration", "Feature", "IsDeleted", "Price", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"), new DateTime(2025, 1, 30, 14, 34, 55, 201, DateTimeKind.Local).AddTicks(3398), null, 10.0, "Like and comment blogs;Update fetus health record", false, 0.0, "Free", null },
                    { new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"), new DateTime(2025, 1, 30, 14, 34, 55, 201, DateTimeKind.Local).AddTicks(3403), null, 10.0, "All the free features;Generate chart;Book doctor in advance", false, 200000.0, "Premium", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CCCD", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmationToken", "FullName", "IsActive", "IsEmailConfirmed", "Password", "PasswordResetToken", "PasswordResetTokenExpiryTime", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "UpdatedAt", "Username" },
                values: new object[] { new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "123456789012", new DateTime(2025, 1, 30, 14, 34, 55, 202, DateTimeKind.Local).AddTicks(8122), new DateOnly(2002, 1, 23), "admin@gmail.com", null, "Admin", true, true, "AQAAAAIAAYagAAAAEPAjuqTao+RFEszMj9P98qq1fOmajCs/QGVV9vC7O6AUsHXW8dYWmifWt7f8uMwCYw==", null, null, null, null, new Guid("825fe2a6-c543-49cb-9d84-1f8cf2864047"), null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5033));
        }
    }
}
