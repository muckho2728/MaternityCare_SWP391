using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDoctorFetusPackage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Slots_SlotId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Fetuses");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Blogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 17, DateTimeKind.Local).AddTicks(4112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 330, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 17, DateTimeKind.Local).AddTicks(1466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 330, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Packages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 15, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Packages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Packages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Packages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 15, DateTimeKind.Local).AddTicks(4460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 328, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Fetuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 14, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Fetuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Fetuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Fetuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 14, DateTimeKind.Local).AddTicks(2225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 13, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 13, DateTimeKind.Local).AddTicks(3979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 328, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 12, DateTimeKind.Local).AddTicks(7487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 12, DateTimeKind.Local).AddTicks(1388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 327, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Slots_SlotId",
                table: "Appointments",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Slots_SlotId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Fetuses");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Fetuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Fetuses");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Fetuses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Doctors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 330, DateTimeKind.Local).AddTicks(2572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 17, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 330, DateTimeKind.Local).AddTicks(76),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 17, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Slots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 328, DateTimeKind.Local).AddTicks(9286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 15, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Fetuses",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 14, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 328, DateTimeKind.Local).AddTicks(514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 13, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 12, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 17, 16, 14, 39, 327, DateTimeKind.Local).AddTicks(4004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 17, 23, 51, 14, 12, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Slots_SlotId",
                table: "Appointments",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "Id");
        }
    }
}
