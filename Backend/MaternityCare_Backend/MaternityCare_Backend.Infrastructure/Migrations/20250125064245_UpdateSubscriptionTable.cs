using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSubscriptionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(6107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 637, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(2579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 637, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Packages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 892, DateTimeKind.Local).AddTicks(453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 636, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(6894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fetuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(2256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(9937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(7566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(3664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 634, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(7647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 634, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(3506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 634, DateTimeKind.Local).AddTicks(839));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 637, DateTimeKind.Local).AddTicks(3419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 637, DateTimeKind.Local).AddTicks(656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 893, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Subscriptions",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Packages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 636, DateTimeKind.Local).AddTicks(1476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 892, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(8734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Fetuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 891, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(3431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 635, DateTimeKind.Local).AddTicks(1723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 634, DateTimeKind.Local).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 890, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 634, DateTimeKind.Local).AddTicks(4001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 14, 9, 22, 634, DateTimeKind.Local).AddTicks(839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 25, 13, 42, 44, 889, DateTimeKind.Local).AddTicks(3506));
        }
    }
}
