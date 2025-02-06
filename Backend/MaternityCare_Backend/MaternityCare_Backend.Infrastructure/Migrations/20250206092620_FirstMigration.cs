using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YearsOfExperience = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Feature = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandardFetusHealths",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    HeadCircumference = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AmnioticFluidLevel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CrownRumpLength = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BiparietalDiameter = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FemurLength = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EstimatedFetalWeight = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AbdominalCircumference = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GestationalSacDiameter = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardFetusHealths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    IsBooked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slots_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    EmailConfirmationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordResetTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Blogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fetuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ConceptionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fetuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fetuses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Likes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FetusHealths",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FetusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    HeadCircumference = table.Column<double>(type: "float", nullable: true),
                    AmnioticFluidLevel = table.Column<double>(type: "float", nullable: true),
                    CrownRumpLength = table.Column<double>(type: "float", nullable: true),
                    BiparietalDiameter = table.Column<double>(type: "float", nullable: true),
                    FemurLength = table.Column<double>(type: "float", nullable: true),
                    EstimatedFetalWeight = table.Column<double>(type: "float", nullable: true),
                    AbdominalCircumference = table.Column<double>(type: "float", nullable: true),
                    GestationalSacDiameter = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FetusHealths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FetusHealths_Fetuses_FetusId",
                        column: x => x.FetusId,
                        principalTable: "Fetuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Avatar", "CreatedAt", "DeletedAt", "Email", "FullName", "IsDeleted", "PhoneNumber", "Specialization", "UpdatedAt", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), "https://maternitycare.blob.core.windows.net/maternitycare/LamVietTrung.jpg", new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2448), null, "lamviettrung@gmail.com", "Lam Viet Trung", false, "0457009809", "Obstetrician", null, 5.0 },
                    { new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), "https://maternitycare.blob.core.windows.net/maternitycare/NguyenThiThuHa.jpg", new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2471), null, "nguyenthithuha@gmail.com", "Nguyen Thi Thu Ha", false, "0137746881", "Obstetrician", null, 7.0 },
                    { new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), "https://maternitycare.blob.core.windows.net/maternitycare/LeThiMinhHong.jpg", new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2467), null, "lethiminhhong@gmail.com", "Le Thi Minh Hong", false, "0862605697", "Obstetrician", null, 3.0 },
                    { new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), "https://maternitycare.blob.core.windows.net/maternitycare/VoDucHieu.jpg", new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2476), null, "voduchieu@gmail.com", "Vo Duc Hieu", false, "0754559328", "Obstetrician", null, 8.0 }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Duration", "Feature", "IsDeleted", "Price", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"), new DateTime(2025, 2, 6, 16, 26, 20, 332, DateTimeKind.Local).AddTicks(6581), null, 10.0, "Like and comment blogs;Update fetus health record", false, 0.0, "Free", null },
                    { new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"), new DateTime(2025, 2, 6, 16, 26, 20, 332, DateTimeKind.Local).AddTicks(6598), null, 10.0, "All the free features;Generate chart;Book doctor in advance", false, 200000.0, "Premium", null }
                });

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("03a4969a-4a6e-4598-ab1d-d67382d8b0a7"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 },
                    { new Guid("1f1a62e2-e8d4-453c-a7e2-70f27571a0da"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("2681c772-28d7-47e9-a7bc-e1c9f68d9742"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("363a958e-352f-44d2-b02d-5856c7beadd9"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("38d65a1b-8707-4d4f-b47c-eb245e6f5ef8"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("4a5f6b3f-361c-4a79-9fe2-0a8d734bc5b4"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 },
                    { new Guid("6a10cacc-b219-4fc2-b72a-a8c2a530904c"), "You’re now considered early term. You should have regular monitoring.", 37 },
                    { new Guid("c353be84-cef6-4278-a887-dc69d98db49e"), "You should have an anomaly scan to examine fetal anatomy.", 18 },
                    { new Guid("d1d2509f-4ffe-493c-8767-ed8512d5a94a"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("416b6528-8c94-4ddc-8413-012b8ee38ae4"), "Member" },
                    { new Guid("825fe2a6-c543-49cb-9d84-1f8cf2864047"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("081e566e-1baa-4d19-b0b0-2167d2c0d318"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("11f2de10-275f-43dc-8b3f-d2e3572ace74"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("1a5aa8c3-29e6-45a3-a721-3341e22cd06f"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("2b2f8638-b1e3-4d71-8102-a61447f9cfab"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("2b3a4243-dd9e-4eb9-bb42-8dfa1d4dd1c5"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("2f0a6b62-2efa-490f-948b-f07d62b8fe02"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("3131e008-0cc2-4078-b28b-639aeb27e38f"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("4bec53cb-6f58-40f3-af36-c3ba1273ce35"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("53cdec06-cd7d-4087-9e65-e40c0b4f5970"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("5a6da19d-0a04-460c-91c7-fe343c5c7741"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("5ff4defa-2bee-48c5-b9f1-dac279c67c82"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("6c0f83be-e3be-4e4e-acf8-feb42428fa54"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("756038dd-a400-44b8-8d22-cf5914337d15"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("76c81405-4bda-420d-bdff-e9ae7043e26c"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("7afaece0-9dc3-4456-9093-8048af71b8e2"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("7e42a4b4-1218-416e-ab92-d3b8f5213020"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("8c1ddf4f-74b2-4404-8f97-b17e8c2b1807"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("b179e197-57ba-4714-a3e0-f634da36adad"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 },
                    { new Guid("bce56d3e-b9fd-4a5f-9552-9add41f20335"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("d985db13-3050-49cd-bc1d-a9c8b03da6ad"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 }
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

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("058fdcfe-62ea-48aa-8d89-6ddded627dd8"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("0abd2476-858f-4e16-9175-7cef2392a9dc"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("1300ecc6-3e10-4423-9902-b339b5266f76"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("1314c564-cb32-47ea-a948-5829a9a10c2b"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("13f8a6af-609e-470c-a396-e11b698234f1"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("1f6bad07-6aaf-463e-8c0d-6125caff8000"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("20e2b8ec-4ac6-4a3b-8920-ffeb5f1344a4"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("23d6fb92-0eb9-4d73-86b0-9886fd54c8a1"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("2602ef37-1426-40d9-90c2-a3eee18d681f"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("263a6317-cfc1-48db-82d5-95d1390ca7ff"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("2cf409c5-77f4-45d1-9d93-94214aabb3d8"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("2daaf64a-f8ff-47b7-80e8-75364ddbb153"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("3af43c61-17ff-4523-823c-238eea4cb150"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("57fa1690-1f6b-4108-965c-dfbfd11ede11"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5ab06c47-9e36-4b30-ae8f-71da725f4ac6"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("6362d81c-c764-464e-9ac1-20b8b662dd86"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("69b93c80-8471-43a6-8046-73edf7c5c93d"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("6fff3d4f-67fc-4fe4-851d-80f8073c175a"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("715f8058-9ed6-4f7a-b2ac-c733723d5a02"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("738f6bf8-366f-4437-98b6-4427bd5634e7"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("743e8dcf-7e76-4cfc-b068-0cff00284b5f"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("77a85e53-028c-48ef-84ff-cb220056faad"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("881f5451-0f77-41ef-a59f-82432b3d0197"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("892201d3-bd32-433f-b2d3-1e1d26ef52e4"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("8a947b93-2b92-440f-8e48-714f496492e0"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("8c209408-f581-4f7b-8113-7413b30cfab9"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("8e97fdf3-e679-4818-99ce-b6432bf78bca"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("91cef874-2ac1-4ed9-8a61-e86e69adf8ed"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("927c58b3-1802-4db5-a5fc-aea11de14b17"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("92b4ae9c-1c8c-41b0-82f0-ca288949e6b0"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("9ef291ff-d312-4d7a-96a2-ef633a88deea"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("a0ae8dc4-669b-4961-9a5b-89876484a6e4"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("a661101b-d2db-4789-ae2d-30c40d1d2f56"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("a78a05ec-1337-4c14-bb3d-0dde9b1777b7"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("acbfbfd3-e94d-4d83-8329-69e2aaec962f"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("ade9385b-d804-4a57-95bc-9dc13ab2bbe5"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("b1b862c4-308c-4b7e-9b5e-f8ceb2705e92"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("b1fb1acc-7a01-4b45-9b04-2d2d11e8e1c3"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b30e7ca9-4c19-4e0c-a2d8-03a75065fbfe"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("b7082fcf-7608-4c64-affc-65ead1735ce6"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("b951e0ba-bfed-4677-bee1-1d2e9fa5e03c"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("bbac8e76-5cdf-4ee9-80e8-42853186c1a5"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("bd836f58-72a5-4965-8af3-471fdae5a0b3"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("bdd656cf-e157-4ce3-b779-3c85bebcf28e"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("c2923f78-9bf6-4866-99cf-f462958d3ff3"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c37d05e3-33a5-4d63-ba53-7b452068f2f4"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c93ad6a2-29f5-4582-84dd-c66bcdde13c8"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("cd0a41d2-08a3-4893-a9fa-db1c605d771b"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("ceabc3ae-98ec-4ce7-b952-99e277976393"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("d01726f1-9627-4183-88d3-d973b664036e"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("d37fcc08-3ac0-4271-84f5-192efb624f8d"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("d4f3c13f-5f6b-4fc8-bd3f-442c8e3f1056"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("dc0a8dcc-ef30-412b-941a-3f049e589eb2"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("dc35ef80-47a9-4bd0-807f-98cf40825f42"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("dfbd596a-5c6b-4176-ae97-4227422c5a96"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("dfc174f5-f924-4502-bfd3-5a2136318521"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("e259b4dd-0d5a-473e-9fff-17418a57f7c9"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("e3652cb4-7b78-497a-9fcd-f67f21fadc23"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e378877a-dcdf-40b3-9adf-3671e7d40520"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e5d3b464-b39f-4d4e-b31d-250ea8b64b7c"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("e6027451-5342-4eea-b22f-c47ab8863726"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("eaf7d77b-3b01-4c6f-b80b-ff20cd973b38"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("f2a4463a-09d9-4974-96db-f24c4f72d8a4"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("fcfb41d2-e100-4065-8c06-c407a4e85c29"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CCCD", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmationToken", "FullName", "IsActive", "IsEmailConfirmed", "Password", "PasswordResetToken", "PasswordResetTokenExpiryTime", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "UpdatedAt", "Username" },
                values: new object[] { new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "123456789012", new DateTime(2025, 2, 6, 16, 26, 20, 334, DateTimeKind.Local).AddTicks(8360), new DateOnly(2002, 1, 23), "admin@gmail.com", null, "Admin", true, true, "AQAAAAIAAYagAAAAENlgL3XfqseKF93QRMi1NH0lAZiNrFeYHNKamrpveYbam/Bva2NTWhpBrIP28JZA7A==", null, null, null, null, new Guid("825fe2a6-c543-49cb-9d84-1f8cf2864047"), null, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SlotId",
                table: "Appointments",
                column: "SlotId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_TagId",
                table: "Blogs",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Fetuses_UserId",
                table: "Fetuses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FetusHealths_FetusId",
                table: "FetusHealths",
                column: "FetusId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_BlogId",
                table: "Likes",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_DoctorId",
                table: "Slots",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_PackageId",
                table: "Subscriptions",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SubscriptionId",
                table: "Transactions",
                column: "SubscriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FetusHealths");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "StandardFetusHealths");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Fetuses");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
