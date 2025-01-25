using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDoctorAndTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsEmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "Subscriptions",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EndDate",
                table: "Subscriptions",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Packages",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Packages",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 892, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fetuses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Avatar", "CreatedAt", "DeletedAt", "Email", "FullName", "IsDeleted", "PhoneNumber", "Specialization", "UpdatedAt", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), "https://maternitycare.blob.core.windows.net/maternitycare/LamVietTrung.jpg", new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5012), null, "lamviettrung@gmail.com", "Lam Viet Trung", false, "0457009809", "Obstetrician", null, 5.0 },
                    { new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), "https://maternitycare.blob.core.windows.net/maternitycare/NguyenThiThuHa.jpg", new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5031), null, "nguyenthithuha@gmail.com", "Nguyen Thi Thu Ha", false, "0137746881", "Obstetrician", null, 7.0 },
                    { new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), "https://maternitycare.blob.core.windows.net/maternitycare/LeThiMinhHong.jpg", new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5028), null, "lethiminhhong@gmail.com", "Le Thi Minh Hong", false, "0862605697", "Obstetrician", null, 3.0 },
                    { new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), "https://maternitycare.blob.core.windows.net/maternitycare/VoDucHieu.jpg", new DateTime(2025, 1, 25, 23, 36, 36, 691, DateTimeKind.Local).AddTicks(5033), null, "voduchieu@gmail.com", "Vo Duc Hieu", false, "0754559328", "Obstetrician", null, 8.0 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("05ac02ec-3fd0-47ad-ab14-4a969bec6e3d"), "Parenting" },
                    { new Guid("3185dbf9-c4be-4c0e-b8e6-4d9ee47bb296"), "Mental Health" },
                    { new Guid("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd"), "Health" },
                    { new Guid("8e18a540-ce22-46d3-ba7b-cde9d20dca38"), "Exercise" },
                    { new Guid("bc557eef-49f8-4bca-8f0a-9700b8c13e7e"), "Nutrition" },
                    { new Guid("d1a17f1e-eb54-43bc-bdac-ca1873c99362"), "Pregnancy" },
                    { new Guid("d5aefed2-5df7-4d2f-bec4-7932da2849de"), "Baby" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("05ac02ec-3fd0-47ad-ab14-4a969bec6e3d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3185dbf9-c4be-4c0e-b8e6-4d9ee47bb296"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8e18a540-ce22-46d3-ba7b-cde9d20dca38"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bc557eef-49f8-4bca-8f0a-9700b8c13e7e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d1a17f1e-eb54-43bc-bdac-ca1873c99362"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d5aefed2-5df7-4d2f-bec4-7932da2849de"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsEmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(6107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(2579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "Subscriptions",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EndDate",
                table: "Subscriptions",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Packages",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Packages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 892, DateTimeKind.Local).AddTicks(453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(6894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fetuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(2256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(9937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(7566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(3664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(7647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(3506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
