using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntityInBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("03a4969a-4a6e-4598-ab1d-d67382d8b0a7"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("1f1a62e2-e8d4-453c-a7e2-70f27571a0da"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("2681c772-28d7-47e9-a7bc-e1c9f68d9742"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("363a958e-352f-44d2-b02d-5856c7beadd9"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("38d65a1b-8707-4d4f-b47c-eb245e6f5ef8"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("4a5f6b3f-361c-4a79-9fe2-0a8d734bc5b4"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("6a10cacc-b219-4fc2-b72a-a8c2a530904c"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("c353be84-cef6-4278-a887-dc69d98db49e"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("d1d2509f-4ffe-493c-8767-ed8512d5a94a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("058fdcfe-62ea-48aa-8d89-6ddded627dd8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0abd2476-858f-4e16-9175-7cef2392a9dc"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1300ecc6-3e10-4423-9902-b339b5266f76"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1314c564-cb32-47ea-a948-5829a9a10c2b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("13f8a6af-609e-470c-a396-e11b698234f1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1f6bad07-6aaf-463e-8c0d-6125caff8000"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("20e2b8ec-4ac6-4a3b-8920-ffeb5f1344a4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("23d6fb92-0eb9-4d73-86b0-9886fd54c8a1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2602ef37-1426-40d9-90c2-a3eee18d681f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("263a6317-cfc1-48db-82d5-95d1390ca7ff"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2cf409c5-77f4-45d1-9d93-94214aabb3d8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2daaf64a-f8ff-47b7-80e8-75364ddbb153"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3af43c61-17ff-4523-823c-238eea4cb150"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("57fa1690-1f6b-4108-965c-dfbfd11ede11"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5ab06c47-9e36-4b30-ae8f-71da725f4ac6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6362d81c-c764-464e-9ac1-20b8b662dd86"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("69b93c80-8471-43a6-8046-73edf7c5c93d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6fff3d4f-67fc-4fe4-851d-80f8073c175a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("715f8058-9ed6-4f7a-b2ac-c733723d5a02"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("738f6bf8-366f-4437-98b6-4427bd5634e7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("743e8dcf-7e76-4cfc-b068-0cff00284b5f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("77a85e53-028c-48ef-84ff-cb220056faad"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("881f5451-0f77-41ef-a59f-82432b3d0197"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("892201d3-bd32-433f-b2d3-1e1d26ef52e4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8a947b93-2b92-440f-8e48-714f496492e0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8c209408-f581-4f7b-8113-7413b30cfab9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8e97fdf3-e679-4818-99ce-b6432bf78bca"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("91cef874-2ac1-4ed9-8a61-e86e69adf8ed"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("927c58b3-1802-4db5-a5fc-aea11de14b17"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("92b4ae9c-1c8c-41b0-82f0-ca288949e6b0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9ef291ff-d312-4d7a-96a2-ef633a88deea"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a0ae8dc4-669b-4961-9a5b-89876484a6e4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a661101b-d2db-4789-ae2d-30c40d1d2f56"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a78a05ec-1337-4c14-bb3d-0dde9b1777b7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("acbfbfd3-e94d-4d83-8329-69e2aaec962f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ade9385b-d804-4a57-95bc-9dc13ab2bbe5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b1b862c4-308c-4b7e-9b5e-f8ceb2705e92"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b1fb1acc-7a01-4b45-9b04-2d2d11e8e1c3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b30e7ca9-4c19-4e0c-a2d8-03a75065fbfe"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b7082fcf-7608-4c64-affc-65ead1735ce6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b951e0ba-bfed-4677-bee1-1d2e9fa5e03c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bbac8e76-5cdf-4ee9-80e8-42853186c1a5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bd836f58-72a5-4965-8af3-471fdae5a0b3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bdd656cf-e157-4ce3-b779-3c85bebcf28e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c2923f78-9bf6-4866-99cf-f462958d3ff3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c37d05e3-33a5-4d63-ba53-7b452068f2f4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c93ad6a2-29f5-4582-84dd-c66bcdde13c8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cd0a41d2-08a3-4893-a9fa-db1c605d771b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ceabc3ae-98ec-4ce7-b952-99e277976393"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d01726f1-9627-4183-88d3-d973b664036e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d37fcc08-3ac0-4271-84f5-192efb624f8d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d4f3c13f-5f6b-4fc8-bd3f-442c8e3f1056"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dc0a8dcc-ef30-412b-941a-3f049e589eb2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dc35ef80-47a9-4bd0-807f-98cf40825f42"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dfbd596a-5c6b-4176-ae97-4227422c5a96"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dfc174f5-f924-4502-bfd3-5a2136318521"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e259b4dd-0d5a-473e-9fff-17418a57f7c9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e3652cb4-7b78-497a-9fcd-f67f21fadc23"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e378877a-dcdf-40b3-9adf-3671e7d40520"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e5d3b464-b39f-4d4e-b31d-250ea8b64b7c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e6027451-5342-4eea-b22f-c47ab8863726"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("eaf7d77b-3b01-4c6f-b80b-ff20cd973b38"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f2a4463a-09d9-4974-96db-f24c4f72d8a4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fcfb41d2-e100-4065-8c06-c407a4e85c29"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("081e566e-1baa-4d19-b0b0-2167d2c0d318"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("11f2de10-275f-43dc-8b3f-d2e3572ace74"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("1a5aa8c3-29e6-45a3-a721-3341e22cd06f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2b2f8638-b1e3-4d71-8102-a61447f9cfab"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2b3a4243-dd9e-4eb9-bb42-8dfa1d4dd1c5"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2f0a6b62-2efa-490f-948b-f07d62b8fe02"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3131e008-0cc2-4078-b28b-639aeb27e38f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("4bec53cb-6f58-40f3-af36-c3ba1273ce35"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("53cdec06-cd7d-4087-9e65-e40c0b4f5970"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5a6da19d-0a04-460c-91c7-fe343c5c7741"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5ff4defa-2bee-48c5-b9f1-dac279c67c82"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("6c0f83be-e3be-4e4e-acf8-feb42428fa54"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("756038dd-a400-44b8-8d22-cf5914337d15"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("76c81405-4bda-420d-bdff-e9ae7043e26c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7afaece0-9dc3-4456-9093-8048af71b8e2"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7e42a4b4-1218-416e-ab92-d3b8f5213020"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8c1ddf4f-74b2-4404-8f97-b17e8c2b1807"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b179e197-57ba-4714-a3e0-f634da36adad"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("bce56d3e-b9fd-4a5f-9552-9add41f20335"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d985db13-3050-49cd-bc1d-a9c8b03da6ad"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 15, 48, 29, 559, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 15, 48, 29, 559, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 15, 48, 29, 559, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 15, 48, 29, 559, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 15, 48, 29, 560, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 13, 15, 48, 29, 560, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("17864828-5a85-43c5-b19d-cbd68d695a6b"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 },
                    { new Guid("2459a116-2eff-4902-9f28-1a95a44e7664"), "You should have an anomaly scan to examine fetal anatomy.", 18 },
                    { new Guid("252e7197-74d0-4ee9-8c80-c2080a4082b1"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 },
                    { new Guid("26c5497e-2d08-4a99-979c-417f02fe8de9"), "You’re now considered early term. You should have regular monitoring.", 37 },
                    { new Guid("385d7197-ddc4-4691-a18f-69028bfa866f"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("872899bf-7eda-4278-8ef6-bf5b1c8e41c4"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("ab275fa8-0692-48ea-b605-c0ad52212321"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("e5785aae-7f12-4840-811d-568a691b3d9d"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("f09a7245-7135-491e-826c-2c032f139f25"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("01e2809f-51a8-4d7d-802b-610a953f0a04"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("02b3ecc7-965e-43c3-ae6f-f6f72e07e283"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("08b319ca-bea1-4e99-abf1-fc4fd262eab2"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("0bd7a836-07a1-4008-82b0-cfd01e9096e4"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("0ca0166d-e485-46f1-b1f8-341eafb965d0"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("10883c90-f08c-45dd-88d8-e94530ae3908"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("119c55ff-c4c2-48dd-9a46-c121194c1ac6"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("1780627b-8f6a-4570-a360-d60147b7aecc"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("1fc75009-4e8e-4eef-a982-e394a2751de4"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("266936f7-72b3-410b-86cf-4c97401d44ef"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("2b60fbd7-9e64-41cb-951c-c087fd0aa18d"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("2c5490b9-6e5b-4af8-94e2-0d40b0b877fd"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("300bc806-59e1-4d01-a005-841e34c3a26f"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("33a01003-0af8-4f5e-b8b5-9215ea4d6e3b"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("35882fe4-a188-4af0-ae8f-91d47c30a6f9"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("3951e6da-316b-471a-a5d1-06a2454e684d"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("39cb1eca-5506-4509-8635-89117c631bcb"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("3b4a3967-1e61-445a-8f3b-de12fb9f1ad7"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("3ee614e2-5aeb-4d26-a1d9-4ec3b7d1cd33"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("41016fa9-ada0-480e-93a4-6f05d0548a79"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("449fff28-e07e-4838-a79a-b3c5b758e16f"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("45746c9d-aea7-479f-8a83-620f68af01b4"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("4814d95a-b732-4076-93db-d8ec3a3f83d6"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("50d8ce6b-8007-4ad4-8369-7379430ac473"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5184a7c1-19de-49c7-8949-655b4d069c41"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("5268720c-a832-4884-859a-b0b4e71813b5"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("59a2f285-0062-45af-b732-9dd26c0d6027"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("5a9a4d7f-c461-4c7e-bcf2-fb605859a83f"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5bbfc837-2498-4373-90bd-d2ffb1200cd1"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5bd4eb7e-febd-472e-8fe5-157c5830e842"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("689aab09-b0bb-4429-9d41-91fa7a92884f"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("68fefba6-cb5e-48d6-b3d3-f3eb58da4dfd"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("69821ef5-0ec3-4f13-b0df-f5bfba1ff8be"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("6b4be058-718f-4f76-b8d3-4e99ce7898b6"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("715d7af3-4d22-4025-940a-61e914e969fb"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("7485497a-5ee6-4e42-b111-d2add7e7c1e9"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("7af16130-54bb-4807-bd69-3176ade7e4f2"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("7bbcc113-3ede-4799-938f-248929afa348"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("7f4fccc0-a8c1-4d3a-9983-15c5efd1bc4b"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("80c417ff-8bb6-4bfe-bd58-a89ced8017da"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("94bfb872-bfcf-4016-bca9-f85202ef569d"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("96ec1631-bd02-494d-9805-2f016453a520"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("97955b49-8428-4746-97f8-620c90045ccb"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("a0135b23-cecd-41d1-9b22-3382844b7a49"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("a6f8245a-a633-44d0-852f-ed18297d75d9"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("ac12b19b-d81a-4a2a-99c2-913abcea035a"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("b06aa3ae-9452-49b3-ab8a-f15306b236e3"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("b412f34c-4f40-43f0-8fc9-9dc656a3449c"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("b57b8119-17c9-475c-b32c-d1596ec1f6eb"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("ba99457a-2dd2-437a-8674-ba0de65dc37e"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("bad2c82f-6642-4f39-a78e-eb18e64ecf79"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("bf253d91-4e84-4f01-8616-bd3ca259d4dd"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("c5d64199-1f41-492e-b554-0684096fbdaa"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c6ea0dfc-a675-41e0-99c0-2b6536ef8c02"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("cae9d941-96b8-443c-af1f-8a5df2b49bb3"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("cee6f989-2f55-45d8-8de7-b76d06c03d88"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("cef4fc68-1f6f-4211-bcff-fa1fba8923fb"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("df7255a4-48fe-46a1-859d-9abd0670c19b"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e2becb2b-ff7e-4d41-ab2d-fc33401551c8"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e631e538-9191-4c5f-be24-d595d3e42c6f"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("ea7b26b0-61a5-4672-827f-bf01e80f3861"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("f2235e2f-32da-49ef-8ddb-ce24bd6f4393"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f6e2f385-43f8-4e3e-bff0-1c587b3a8cf2"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("fc5a3e27-6bf3-4b18-9b9a-7b2c5726dac5"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("098d7443-b576-4f3f-9b89-957d2632bf5c"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("0abdd185-fe0f-4bb5-b6ca-e5a9fcd64782"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("1c80b487-2c90-4e2f-8cf6-74b48649057c"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("2835120e-dc22-41d4-bc36-c2d55d121a45"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("2f1d5443-cf29-4f32-b7ba-f1918990adc3"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("320a98f2-3813-4a58-898a-3c9fdfb805cd"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("3cfc9a9b-96ea-4857-b832-a23dadbcc35c"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("46d1127e-5960-457e-bd5d-6005b22f2415"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("5063fe8f-083d-4a5b-9413-858f03e668ee"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 },
                    { new Guid("865925b1-dd88-45d0-9e18-1a24ffef32cd"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("87387f98-6811-4185-bb10-273f024fb299"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("8f43d81b-ccd1-47f6-a5aa-d6b5148e9f1f"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("ad131c2f-22ee-480d-8e71-4728d9a0c982"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("af7c9de4-e26a-46fd-afa4-53ca592fdb69"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("b6729b1c-4402-48d8-9b98-7aaa5cb1bc42"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("e3b80570-9d08-4f96-8390-8eaface7802c"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("e80efa0c-fab9-4778-ade1-960e094a62f4"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("f3487697-e02b-4148-83c8-e47d1edd850a"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("f7e64e14-8d75-46ab-8603-187cbbdd3169"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("f859af80-57b0-434d-b468-4bf49fe32c3e"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 48, 29, 562, DateTimeKind.Local).AddTicks(8821), "AQAAAAIAAYagAAAAEHSlbO/JU3uup/vJnZffFik55OaROs3ijBVUrncPg1W3fEAAzKF3EtNTbxzNVgTpyQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("17864828-5a85-43c5-b19d-cbd68d695a6b"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("2459a116-2eff-4902-9f28-1a95a44e7664"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("252e7197-74d0-4ee9-8c80-c2080a4082b1"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("26c5497e-2d08-4a99-979c-417f02fe8de9"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("385d7197-ddc4-4691-a18f-69028bfa866f"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("872899bf-7eda-4278-8ef6-bf5b1c8e41c4"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("ab275fa8-0692-48ea-b605-c0ad52212321"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("e5785aae-7f12-4840-811d-568a691b3d9d"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("f09a7245-7135-491e-826c-2c032f139f25"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("01e2809f-51a8-4d7d-802b-610a953f0a04"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("02b3ecc7-965e-43c3-ae6f-f6f72e07e283"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("08b319ca-bea1-4e99-abf1-fc4fd262eab2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0bd7a836-07a1-4008-82b0-cfd01e9096e4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0ca0166d-e485-46f1-b1f8-341eafb965d0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("10883c90-f08c-45dd-88d8-e94530ae3908"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("119c55ff-c4c2-48dd-9a46-c121194c1ac6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1780627b-8f6a-4570-a360-d60147b7aecc"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1fc75009-4e8e-4eef-a982-e394a2751de4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("266936f7-72b3-410b-86cf-4c97401d44ef"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2b60fbd7-9e64-41cb-951c-c087fd0aa18d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2c5490b9-6e5b-4af8-94e2-0d40b0b877fd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("300bc806-59e1-4d01-a005-841e34c3a26f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("33a01003-0af8-4f5e-b8b5-9215ea4d6e3b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("35882fe4-a188-4af0-ae8f-91d47c30a6f9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3951e6da-316b-471a-a5d1-06a2454e684d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("39cb1eca-5506-4509-8635-89117c631bcb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3b4a3967-1e61-445a-8f3b-de12fb9f1ad7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3ee614e2-5aeb-4d26-a1d9-4ec3b7d1cd33"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("41016fa9-ada0-480e-93a4-6f05d0548a79"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("449fff28-e07e-4838-a79a-b3c5b758e16f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("45746c9d-aea7-479f-8a83-620f68af01b4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4814d95a-b732-4076-93db-d8ec3a3f83d6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("50d8ce6b-8007-4ad4-8369-7379430ac473"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5184a7c1-19de-49c7-8949-655b4d069c41"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5268720c-a832-4884-859a-b0b4e71813b5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("59a2f285-0062-45af-b732-9dd26c0d6027"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5a9a4d7f-c461-4c7e-bcf2-fb605859a83f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5bbfc837-2498-4373-90bd-d2ffb1200cd1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5bd4eb7e-febd-472e-8fe5-157c5830e842"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("689aab09-b0bb-4429-9d41-91fa7a92884f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("68fefba6-cb5e-48d6-b3d3-f3eb58da4dfd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("69821ef5-0ec3-4f13-b0df-f5bfba1ff8be"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6b4be058-718f-4f76-b8d3-4e99ce7898b6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("715d7af3-4d22-4025-940a-61e914e969fb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7485497a-5ee6-4e42-b111-d2add7e7c1e9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7af16130-54bb-4807-bd69-3176ade7e4f2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7bbcc113-3ede-4799-938f-248929afa348"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7f4fccc0-a8c1-4d3a-9983-15c5efd1bc4b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("80c417ff-8bb6-4bfe-bd58-a89ced8017da"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("94bfb872-bfcf-4016-bca9-f85202ef569d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("96ec1631-bd02-494d-9805-2f016453a520"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("97955b49-8428-4746-97f8-620c90045ccb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a0135b23-cecd-41d1-9b22-3382844b7a49"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a6f8245a-a633-44d0-852f-ed18297d75d9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ac12b19b-d81a-4a2a-99c2-913abcea035a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b06aa3ae-9452-49b3-ab8a-f15306b236e3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b412f34c-4f40-43f0-8fc9-9dc656a3449c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b57b8119-17c9-475c-b32c-d1596ec1f6eb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ba99457a-2dd2-437a-8674-ba0de65dc37e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bad2c82f-6642-4f39-a78e-eb18e64ecf79"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bf253d91-4e84-4f01-8616-bd3ca259d4dd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c5d64199-1f41-492e-b554-0684096fbdaa"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c6ea0dfc-a675-41e0-99c0-2b6536ef8c02"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cae9d941-96b8-443c-af1f-8a5df2b49bb3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cee6f989-2f55-45d8-8de7-b76d06c03d88"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cef4fc68-1f6f-4211-bcff-fa1fba8923fb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("df7255a4-48fe-46a1-859d-9abd0670c19b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e2becb2b-ff7e-4d41-ab2d-fc33401551c8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e631e538-9191-4c5f-be24-d595d3e42c6f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ea7b26b0-61a5-4672-827f-bf01e80f3861"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f2235e2f-32da-49ef-8ddb-ce24bd6f4393"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f6e2f385-43f8-4e3e-bff0-1c587b3a8cf2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fc5a3e27-6bf3-4b18-9b9a-7b2c5726dac5"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("098d7443-b576-4f3f-9b89-957d2632bf5c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("0abdd185-fe0f-4bb5-b6ca-e5a9fcd64782"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("1c80b487-2c90-4e2f-8cf6-74b48649057c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2835120e-dc22-41d4-bc36-c2d55d121a45"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2f1d5443-cf29-4f32-b7ba-f1918990adc3"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("320a98f2-3813-4a58-898a-3c9fdfb805cd"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3cfc9a9b-96ea-4857-b832-a23dadbcc35c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("46d1127e-5960-457e-bd5d-6005b22f2415"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5063fe8f-083d-4a5b-9413-858f03e668ee"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("865925b1-dd88-45d0-9e18-1a24ffef32cd"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("87387f98-6811-4185-bb10-273f024fb299"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8f43d81b-ccd1-47f6-a5aa-d6b5148e9f1f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ad131c2f-22ee-480d-8e71-4728d9a0c982"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("af7c9de4-e26a-46fd-afa4-53ca592fdb69"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b6729b1c-4402-48d8-9b98-7aaa5cb1bc42"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e3b80570-9d08-4f96-8390-8eaface7802c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e80efa0c-fab9-4778-ade1-960e094a62f4"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f3487697-e02b-4148-83c8-e47d1edd850a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f7e64e14-8d75-46ab-8603-187cbbdd3169"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f859af80-57b0-434d-b468-4bf49fe32c3e"));

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Blogs");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 16, 26, 20, 331, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 16, 26, 20, 332, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 16, 26, 20, 332, DateTimeKind.Local).AddTicks(6598));

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 26, 20, 334, DateTimeKind.Local).AddTicks(8360), "AQAAAAIAAYagAAAAENlgL3XfqseKF93QRMi1NH0lAZiNrFeYHNKamrpveYbam/Bva2NTWhpBrIP28JZA7A==" });
        }
    }
}
