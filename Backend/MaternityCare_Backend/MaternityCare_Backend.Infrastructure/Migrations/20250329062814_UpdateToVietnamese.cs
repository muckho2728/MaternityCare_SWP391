using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateToVietnamese : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("0626a94e-0c1e-4b03-a89f-92a80226ef4c"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("1e87eab6-5884-42b6-ace7-e3596313bf40"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("79174348-a036-4ceb-ad0a-acd060b1559e"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("7aa367e9-c2b2-4438-bcde-76f4b5a73865"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("918f4a47-8ae7-4a8d-9d09-8a48b12170d6"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("b11caea5-07b2-41f7-ac94-620407396a3e"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("b8b3b7c2-45ef-4841-9f62-b51071868bd9"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("cce6a20f-d44b-4972-a06e-0fa9c6bdc2ac"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("cf4f01c7-b589-4fa5-885a-ece124540629"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("02940367-9b57-46d7-a655-5dd375107f08"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0898ce30-75cf-4335-a9e6-182f70827f30"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0bf7bd5a-c9df-40d9-9a54-0f598dd387c1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("165a6c55-4bd2-46be-82aa-5c6610b42ca8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("16ce34b1-6e85-43e3-8ffa-8352bbfaa3e6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1b6d2a77-1ff4-4b08-a9b0-125534a24076"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1d2d4cde-aaea-407f-8b8d-4278ffcdc8d1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1d659aed-e893-4d8f-a97d-80c72e04bf42"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("20cc8547-7ea9-487e-bf9e-24c20e8486a1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2201a05f-5df8-4164-bb63-0a6e50eef621"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("37ad9c65-fc79-4ec4-b132-068243a50594"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3b93b9ca-eff0-488d-abe2-b548bd747c83"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("46d5da75-67ed-4f41-9038-c0d29347c2ee"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("47a3e3eb-c8e4-4851-90bf-95db676cbb76"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4d60a1e1-b9e2-4631-9897-37b6164cb437"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4e127521-c1c2-4242-81ae-b9ab071f9bff"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("51c8f18f-a181-4d09-a1b2-8c63753e1a34"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("525e7d0d-5448-4a87-ac38-38361f54527d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("533d5632-6245-4998-bad2-1b9ab008d3ce"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5840db7b-adf2-456a-9fd7-5b79fac7cea8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5ddb9494-ba0c-4158-bfa3-0ac98e6c0e17"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5f292a2b-1731-4aa4-92aa-15a47e10f6f0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("66966a1e-f573-41a9-ac1b-1c818e21af58"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6793c9d8-67eb-48a2-bfd4-0358692f59e1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6baf8a20-e403-4ae9-8977-2c74bc819b2d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6be07b6d-d263-4cf0-a37e-9b99e41489ae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6befdd5d-03bd-4eec-8184-db9d56336219"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6e003380-0aed-4450-ac86-d34e6a09f430"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("71f16a86-0dc4-4438-bf51-cf908fe5a098"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("76d9d022-d36a-427e-9fb6-26caf9030be7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("79b46bdf-9513-4e9f-af75-9d0a690e393f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("80f53f34-511d-4016-bb97-426b78067e5e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("869b7901-4d1e-4354-b8c3-743f43b34af8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("874444a8-efea-4d67-af5d-a6ccd4b7e288"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9bf27509-a61a-4f2b-ac38-ebabe0fb9e6a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a433a6ee-a9fd-41d8-9eff-318030efe94b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a49b9656-b137-4fa9-b248-4264a425c06b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a621731e-95e9-43a5-814d-8597f966dfd0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a63f400b-be6c-46da-8d8b-7261a7fce8b2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b01abc9c-57a4-443c-a3f1-54192ec92bdc"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b3a36e1a-fdc2-4874-9e79-427f3893c0e4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b939351c-6e50-4c0d-95bc-3c4729335538"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bf6bfcfe-e224-4384-b977-0e99d00e82cb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c00cce24-c382-4873-9c88-167c59828f38"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c05debcb-e0de-4a96-bbb7-2fff43af554e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c5070e07-3865-402c-9cee-39705797a9f3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c5f9abba-dce3-4c7c-b490-1ce8973ad8cd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c7762427-305c-4149-a152-239205fae052"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c86ef861-8249-4b62-8f41-fabc4a8c2b33"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cf67cd21-3b67-488b-91db-e9a5f84db162"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d02e4cd1-e32f-4209-8260-bb3defeeb6a9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d82be5b0-cd5a-4ea7-b240-10d52352e343"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dd6a5396-d3b7-49c1-8cf8-0e408a9f967f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("de324f31-c462-4860-9126-454b7fc729f8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e0516533-2b76-4064-81d2-303789caeb27"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e05f1d38-417d-45c8-a33c-bd90c4864798"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e1aa703c-1dda-402e-9fe6-f5305aefdb09"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e60d2512-a6dc-4daa-b915-56465f8181a0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e6316b0f-f73b-49e4-8992-6ab6675d48da"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e78525f2-608b-424b-85d9-44f32085e241"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ed36d74b-4ea0-427e-a370-39b976b3b1e3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f6dd4e39-6115-4bf1-b246-c813f339f752"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fdca5a10-b4cf-4e1f-a2e8-97ef1d4f2c78"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fe8ab826-c5ae-4ae7-9d77-53be7a50ebe0"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("05dd1e97-432a-46a7-bbad-a286486ee2ee"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("0bd302ec-ee8a-4c94-b418-20a3ba198dcc"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("0f6364da-8523-4f9f-8526-085ae467b6cf"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("1ac1af94-4ce8-4745-a00b-34b5cc122104"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("231df9a7-78f7-4eb1-aeca-b086fc17e5f7"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("30e14770-a38b-4911-a52e-a06af2836061"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("33df37f1-7141-4581-81c7-e24e34b81e02"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("343e20cb-110c-4e8e-b294-d6436c0e527a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("38905c51-bad2-4eab-8660-ed4e372bb3fa"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3f5e4b9f-696d-45f9-b255-ce82ab578193"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("441babce-0ac5-4a81-87ac-8cc146e753e2"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("46b04f89-f850-4843-b210-fd2e6cafa518"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("46bfe5b5-e6aa-4ec2-89cf-cc7077c51fa6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("48d169f8-ec3c-4db2-8d18-f1a43e375741"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("51126d77-871e-4842-ae5d-c6ab0e19378a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("51224f66-5f65-4ed7-a08f-11ff3dd527da"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5641bf64-092c-4ea3-990a-a146cd2e2c6d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5f157f94-732f-47f7-978e-9864e6bd4627"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("60823d3e-ef74-4ee3-8686-0b3f582751fe"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("60d5c0dc-faf4-4ba0-8a1a-662709efb641"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("650b2907-496a-4a86-8951-589d87bd7a8d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("666045cf-38a8-4502-a557-c9d0915ca859"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7c2eae5a-9e12-4ebb-b492-bfeb79fc1304"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8020a5bf-bd01-4958-9e17-64264a3ddb8a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("9573452b-683b-4170-992b-5ab059e89bd6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("a984a5c5-c252-4591-a549-a5b109b73df5"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("aae2b927-72ef-492c-88db-fc979d275dde"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b1195917-fab4-494c-9204-32296938657c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("bd659b1f-2673-40c9-a648-dae1b6184a01"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c260167c-c915-4f76-a112-780878cc9add"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c97d1d98-5fcb-4b42-96df-90ace5ced451"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e329809c-6b87-4c79-9ce3-91ea11f6f269"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e49bf254-c814-489f-9561-93a39abbe664"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e9567102-ed2c-477d-b279-31adbe88cac5"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e997a352-e80f-4777-8de5-11ae87ff3a7c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ed1ce099-c9bd-462f-bcd3-7de40b7740d6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f07a039e-5a76-4e35-900f-cbf1692bb12c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f2f82f06-cb3c-4e3e-88eb-003f2d79012d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f7dd6207-b132-4ce0-91b6-8919491586cd"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "NVARCHAR(MAX)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reminders",
                type: "NVARCHAR(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Packages",
                type: "NVARCHAR(MAX)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Feature",
                table: "Packages",
                type: "NVARCHAR(MAX)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Doctors",
                type: "NVARCHAR(MAX)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("525be099-6b93-4889-9384-e986fcd8595a"),
                columns: new[] { "Content", "CreatedAt", "Title" },
                values: new object[] { "Tôi sẽ bước sang tuần thứ 26 vào đúng ngày mai nhưng tôi đã bắt đầu cho con bú có lẽ là 3 tuần trước. Lúc đầu chỉ là những đốm nhỏ nhưng giờ tôi thức dậy với cả hai núm vú ướt đẫm áo. Bác sĩ sản phụ khoa của tôi nói rằng đừng lo lắng nhưng tôi muốn hiểu tại sao lại sớm như vậy. Bạn có ý tưởng nào không?", new DateTime(2025, 3, 29, 13, 28, 14, 49, DateTimeKind.Local).AddTicks(6961), "26 tuần cho con bú" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("8081a98b-ec3a-4bd2-965d-063617722541"),
                columns: new[] { "Content", "CreatedAt", "Title" },
                values: new object[] { "Đỉnh điểm của tôi là vào ngày 18 tháng 2 và tôi rụng trứng vào ngày 19. Kỳ kinh của tôi được cho là bắt đầu vào ngày 1 tháng này. Hôm nay là ngày 4 tháng 3 và tôi vẫn chưa có kinh. Tuy nhiên, tôi bị ra máu nâu khi đi tiểu và lau, nhưng không phải lúc nào cũng vậy. Tôi đã thử thai vào sáng nay và kết quả là âm tính. Nhiệt độ cơ thể của tôi là 98°F kể từ ngày 28. Tôi bị ra dịch trắng vào ngày 2 và ngày 3. Tôi bắt đầu ra máu nâu vào buổi sáng", new DateTime(2025, 3, 29, 13, 28, 14, 49, DateTimeKind.Local).AddTicks(6980), "Đây có thể là chảy máu do cấy ghép tử cung? Có ai gặp phải chu kỳ tương tự không?" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("d53abcd4-5ad4-42cd-b5ac-c00bdbd5191c"),
                columns: new[] { "Content", "CreatedAt", "Title" },
                values: new object[] { "Tôi đạt đỉnh rụng trứng vào ngày 8 và BD hai lần một ngày trong suốt tháng. Ngày hôm sau, tôi bị đau núm vú cứng và siêu mềm. (Tôi biết là bình thường sau khi rụng trứng) kể từ đó ngực tôi bị đau và núm vú của tôi cũng đau như vậy. Tôi không bắt đầu kỳ kinh nguyệt cho đến ngày 23 và tôi thường có PMS 5 ngày trước đó. Có thể đó là một triệu chứng không? \r\n-tôi đã uống vitamin và ăn uống lành mạnh nhất có thể trong khi cũng tránh xa caffeine", new DateTime(2025, 3, 29, 13, 28, 14, 49, DateTimeKind.Local).AddTicks(6977), "Đây có thể là dấu hiệu của việc mang thai sớm?" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 29, 13, 28, 14, 50, DateTimeKind.Local).AddTicks(1760), "Bác sĩ sản khoa" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 29, 13, 28, 14, 50, DateTimeKind.Local).AddTicks(1791), "Bác sĩ sản khoa" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 29, 13, 28, 14, 50, DateTimeKind.Local).AddTicks(1778), "Bác sĩ sản khoa" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 29, 13, 28, 14, 50, DateTimeKind.Local).AddTicks(1794), "Bác sĩ sản khoa" });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                columns: new[] { "CreatedAt", "Duration", "Feature", "Type" },
                values: new object[] { new DateTime(2025, 3, 29, 13, 28, 14, 51, DateTimeKind.Local).AddTicks(4561), 0.0, "Thích và bình luận các bài đăng", "Miễn phí" });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                columns: new[] { "CreatedAt", "Feature" },
                values: new object[] { new DateTime(2025, 3, 29, 13, 28, 14, 51, DateTimeKind.Local).AddTicks(4568), "Tất cả chức năng của miễn phí;Tạo biểu đồ;Đặt lịch hẹn với bác sĩ;Thêm nhận xét về trang" });

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("2b04b54f-a888-4870-a184-a4353448d812"), "Bây giờ bạn được coi là thai kỳ sớm. Bạn nên được theo dõi thường xuyên.", 37 },
                    { new Guid("33b96902-9c3b-43c8-ba15-f726443bda95"), "Đây là thời điểm bắt đầu của tam cá nguyệt thứ ba. Bạn nên có lịch trình xét nghiệm hoặc sàng lọc bổ sung (như thiếu máu hoặc tiểu đường thai kỳ)", 25 },
                    { new Guid("34b1e18b-f8de-413f-8188-3371c95a8d4f"), "Bây giờ bạn được coi là đủ tháng. Bạn nên tham dự tất cả các cuộc hẹn khám thai theo lịch trình và liên hệ với bác sĩ nếu bạn gặp bất kỳ thay đổi hoặc khó chịu nào.", 39 },
                    { new Guid("8f0af54a-28b1-4e3c-a4f5-d825f37de24c"), "Từ bây giờ, bạn phải lên lịch hẹn khám với bác sĩ một lần mỗi tuần để đảm bảo em bé phát triển khỏe mạnh.", 31 },
                    { new Guid("93f7ab78-f6ad-4e74-901a-429fb17b0004"), "Bạn nên siêu âm dị tật để kiểm tra giải phẫu thai nhi.", 18 },
                    { new Guid("9d7fdfc8-ed07-4988-8cc4-5507b7c858b5"), "Bạn nên đi khám thai lần đầu và siêu âm hoặc xét nghiệm máu để xác nhận tình trạng mang thai.", 5 },
                    { new Guid("c3321f2f-bed0-41de-830c-12b0937597f0"), "Bạn nên siêu âm vào giữa thai kỳ để kiểm tra sự phát triển của thai nhi.", 20 },
                    { new Guid("f4bcc0db-020c-4bb6-8816-cb92cd83317d"), "Bạn nên sàng lọc trong tam cá nguyệt đầu tiên để kiểm tra tình trạng nhiễm sắc thể.", 9 },
                    { new Guid("f9e15e4e-21c4-4960-af24-aa3f704477aa"), "Đây là thời điểm bắt đầu của tam cá nguyệt thứ hai. Kiểm tra sức khỏe định kỳ là điều cần thiết để kiểm tra xem thai kỳ có tiến triển bình thường không", 13 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("046f0108-1082-4d34-a26c-34a2369eb158"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("06d7fcdb-fd15-4ea6-bed4-a31204235799"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("09515cc7-6df5-4da8-bef6-ef2b241448a3"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("0c5b8eea-162c-4117-b157-e30a1f450d9e"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("0c73033d-5f7e-4d14-b685-5079c72331aa"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("143c8a2c-ac0f-484c-94da-0252c915bf64"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("144e3813-f72a-4ffc-a193-92123ed498df"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("15283308-24e0-4417-993e-7059eddebb9b"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1572a7cd-65f0-45dd-a1e2-0b9e6b772f11"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1e96008f-1684-4210-b525-57cdd5e38236"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("1f61207d-7fbf-44ba-8435-03110c0a2005"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("22b7f013-fe39-4a85-aedf-52f29ec71a43"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("2866a75e-1a60-4ccf-82c8-51c3416cebfe"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("2b193085-5a66-45b8-8cf0-6d7b608da145"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("2e436526-8e5d-498c-9c06-a0a5e635428e"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("304a9c56-ffd2-4c25-8578-ed1b5fea77a1"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("33610a29-6f29-4aca-b47e-5a42ec0897cb"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("36454aef-bf45-40e3-a97c-d10c6096eb5a"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("3a7149b0-5462-42f7-96cc-351ae4af1f36"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("3c29859a-2822-4367-afb2-6c3e076fb000"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("420e3107-39b2-40a8-9d53-132eaa40bf5d"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("45175c57-6e75-4fde-9871-749a88432479"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("56dfa871-d9ee-4de6-a60e-12af36cb4a30"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("572bc21e-62d5-4005-b2bb-2afc7f179949"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("6395993b-fe8d-4447-a8ad-0b11557fbfff"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("66a062c2-d005-4de3-946e-f2ad5fb4946c"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("6a36e996-e02e-407d-a0ae-a958b4a2478b"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("6bade1fd-0a1e-4fbf-9aa6-d16d758c02f6"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("6c0eeb9a-0771-457f-94a4-ff7c08feb741"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("70022040-3cfc-4177-99bb-07e365902467"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("7163d5cf-dd74-49f7-9eba-16c13ac2c8ab"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("76fc645a-9d75-4281-86b9-a332a6ed6c94"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("77017673-39b7-4ca9-9770-44b91605febb"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("866112e6-a343-4a27-b50e-4477806ab3a8"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("8ec654b6-2480-422b-a305-047aec5c77ae"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("8ecd922d-37bb-4431-a3d1-4015d2186430"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("90c13672-f8ca-4f24-897d-141354db17f4"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("96fb8a44-785a-47df-b897-122bba6fd0ae"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("a971f955-2742-42fe-a1a4-5ab9eb63120f"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("ad13cf7b-28d9-4eed-ba4a-6a4f40c7f17e"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("afa1b54a-4a11-445a-a3e7-2aaddd652aae"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b1db6b2f-00ad-4f23-91da-fbc54dbd3aea"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b2204502-05bc-4595-9e51-95eb142213b9"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("b90e2a11-441d-4238-8628-327fd92da117"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("ba8cf908-cc97-4cb2-b74d-d872626f1650"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("bbea7c7d-23c1-44d4-93e9-dc8e550fcad3"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c71ff570-3503-4374-a716-1e2e7d39ee01"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("c7774954-bdcc-4819-a9b2-c6457c0e5b0a"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("cad37dc0-1c08-4795-893f-72c9333f3335"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("cf269ab6-f12f-4a95-9318-200c151588ca"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("cfc39fb6-3816-42ab-b76a-28a4043f262e"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("cfdbe34e-f42a-48b6-87ab-0937ab8227fb"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("d6eae82d-0620-4b90-9dff-ff62945dbb89"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("d9e13efc-dd1c-4e57-b09c-07365525d73a"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("dd33950f-d363-4804-9463-329edd2decf8"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("ddb20565-2b52-42fd-a60d-cf136c710d17"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("e1ccc00a-94b9-44d6-a840-c009663e8392"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e25426d6-5621-47f7-be14-97154e4d2022"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("e3d72e86-7d81-4c7a-8799-8ddd8a764a93"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e53e5b9c-e8fa-4f11-bb9b-48a6fe8d9a61"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e9365da9-7506-4ccb-b24b-22974f173187"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("ece91944-a6ce-49f9-aea0-21542bd806de"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("f91da06e-c009-40c6-ba2c-4d273bbfc606"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("fcb1be71-e3b8-4302-8aa1-a5f68317d483"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("01df5a0b-bbc8-4619-be38-5ec5cec184d7"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("07260b9c-2335-415e-882e-bdbfd5844b7b"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("07ec310e-8341-41c4-a1c5-59d55aee1e13"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("0a856f1d-5092-4c15-bd98-aa03cb1c3c33"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 33 },
                    { new Guid("11e46091-542a-4fd3-8181-f124de17e08f"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("13b3204f-ffb5-43f9-945d-0a2e385299d4"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("1a1f3248-052c-4694-87d4-0ffd48c4da04"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 27 },
                    { new Guid("22cb4b44-e807-4492-b04c-6d8492e1f7e6"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 17 },
                    { new Guid("2e0fcac3-7fea-43c0-b7e3-98644428b229"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 35 },
                    { new Guid("2f8c02d5-7882-478e-a05d-fb715f788830"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 11 },
                    { new Guid("3320732c-525a-473e-af19-e5ad82a0f64c"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 29 },
                    { new Guid("34cdfc41-dc00-47cb-a620-1ee46e55bae3"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 39 },
                    { new Guid("39b530c8-6ae9-4dbb-84be-503535d475a6"), null, null, null, null, null, null, null, null, 5 },
                    { new Guid("3b9e8134-a00b-4330-b7f0-13c122a1d49e"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 25 },
                    { new Guid("4525ba1d-8677-428d-84d2-6b72a93b6865"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("51868f16-fef9-45c9-9db5-2bcc36d91ad8"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("6193bb60-567f-460c-b279-8b1007cd1822"), null, null, null, null, null, null, null, null, 4 },
                    { new Guid("6720ea86-a598-4fb3-b71b-333e776436c0"), null, null, null, null, null, null, null, null, 2 },
                    { new Guid("6c260729-e694-42f9-808c-48e33ae10361"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 },
                    { new Guid("6d7a71a0-d891-4fc1-b58c-08e807423ebc"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 13 },
                    { new Guid("6de5cdfd-96f8-4ea4-9dc5-2a36753d1bff"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("779ccfda-d05f-4996-93e8-37bb889ac889"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 21 },
                    { new Guid("947adc36-7132-49d2-b619-10f5b7de9d1f"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("aaf24e8a-baed-4857-aa66-1a504f0e3815"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 19 },
                    { new Guid("b49cb677-1113-4fd3-8578-eece2dd4c2fa"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("b5fcd0fc-7cc1-4fee-8e5b-d6f5924ffcac"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 15 },
                    { new Guid("d56fdd35-3f2d-4fca-81c7-32155b021c05"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("d63e989d-9972-4336-8fec-d8536c901ed2"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 23 },
                    { new Guid("e0b89eda-66ee-4464-922a-0d02995d11ab"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("e8320733-bd59-4d22-8835-301cee37a295"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("ed48c3dd-8434-47dd-b2bf-502f5ddd04fe"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("ef8e59e2-a504-46ef-b383-ef47f6834d33"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 37 },
                    { new Guid("f0eb3c07-af91-490a-9897-886c2ef39b7e"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("f614faa3-a038-4074-855b-180fbcfe9a3a"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("f68c9a70-065f-4077-86d9-4cf5ab9391bb"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("f6f1292f-71a4-4995-b137-e54be0da8a47"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("f9e5a9f6-4431-49ed-a73a-73d93247a0fe"), null, null, null, null, null, null, null, null, 3 },
                    { new Guid("fb7440d7-2f6a-4726-9db2-a70d872a31cb"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 31 },
                    { new Guid("fd62b6bb-4f75-4f20-a163-cac6362648f2"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 }
                });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("05ac02ec-3fd0-47ad-ab14-4a969bec6e3d"),
                column: "Name",
                value: "Nuôi dạy con cái");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3185dbf9-c4be-4c0e-b8e6-4d9ee47bb296"),
                column: "Name",
                value: "Sức khỏe tinh thần");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd"),
                column: "Name",
                value: "Sức khỏe");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8e18a540-ce22-46d3-ba7b-cde9d20dca38"),
                column: "Name",
                value: "Bài tập thể dục");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bc557eef-49f8-4bca-8f0a-9700b8c13e7e"),
                column: "Name",
                value: "Dinh dưỡng");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d1a17f1e-eb54-43bc-bdac-ca1873c99362"),
                column: "Name",
                value: "Mang thai");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d5aefed2-5df7-4d2f-bec4-7932da2849de"),
                column: "Name",
                value: "Em bé");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
                columns: new[] { "CCCD", "CreatedAt", "Email", "FullName", "Password", "Username" },
                values: new object[] { "082202000011", new DateTime(2025, 3, 29, 13, 28, 14, 112, DateTimeKind.Local).AddTicks(8029), "thuhuong@gmail.com", "Trần Thị Thu Hương", "AQAAAAIAAYagAAAAENB8p6WFc5ockJFBj1WTbe5EQlOwjSvubzhfOHnLMoNcG5E6uwLuajbcNPxhgVQfsg==", "thuhuong" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 3, 29, 13, 28, 14, 53, DateTimeKind.Local).AddTicks(4749), "AQAAAAIAAYagAAAAEEbUQKPlL2I4v7WzRw1MHGB8ozI+ih30zzNzgI6fM3/DOX59mLqSKJXyQC+j/qw37Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("2b04b54f-a888-4870-a184-a4353448d812"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("33b96902-9c3b-43c8-ba15-f726443bda95"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("34b1e18b-f8de-413f-8188-3371c95a8d4f"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("8f0af54a-28b1-4e3c-a4f5-d825f37de24c"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("93f7ab78-f6ad-4e74-901a-429fb17b0004"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("9d7fdfc8-ed07-4988-8cc4-5507b7c858b5"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("c3321f2f-bed0-41de-830c-12b0937597f0"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("f4bcc0db-020c-4bb6-8816-cb92cd83317d"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("f9e15e4e-21c4-4960-af24-aa3f704477aa"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("046f0108-1082-4d34-a26c-34a2369eb158"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("06d7fcdb-fd15-4ea6-bed4-a31204235799"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("09515cc7-6df5-4da8-bef6-ef2b241448a3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0c5b8eea-162c-4117-b157-e30a1f450d9e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0c73033d-5f7e-4d14-b685-5079c72331aa"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("143c8a2c-ac0f-484c-94da-0252c915bf64"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("144e3813-f72a-4ffc-a193-92123ed498df"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("15283308-24e0-4417-993e-7059eddebb9b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1572a7cd-65f0-45dd-a1e2-0b9e6b772f11"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1e96008f-1684-4210-b525-57cdd5e38236"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1f61207d-7fbf-44ba-8435-03110c0a2005"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("22b7f013-fe39-4a85-aedf-52f29ec71a43"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2866a75e-1a60-4ccf-82c8-51c3416cebfe"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2b193085-5a66-45b8-8cf0-6d7b608da145"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2e436526-8e5d-498c-9c06-a0a5e635428e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("304a9c56-ffd2-4c25-8578-ed1b5fea77a1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("33610a29-6f29-4aca-b47e-5a42ec0897cb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("36454aef-bf45-40e3-a97c-d10c6096eb5a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3a7149b0-5462-42f7-96cc-351ae4af1f36"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3c29859a-2822-4367-afb2-6c3e076fb000"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("420e3107-39b2-40a8-9d53-132eaa40bf5d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("45175c57-6e75-4fde-9871-749a88432479"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("56dfa871-d9ee-4de6-a60e-12af36cb4a30"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("572bc21e-62d5-4005-b2bb-2afc7f179949"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6395993b-fe8d-4447-a8ad-0b11557fbfff"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("66a062c2-d005-4de3-946e-f2ad5fb4946c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6a36e996-e02e-407d-a0ae-a958b4a2478b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6bade1fd-0a1e-4fbf-9aa6-d16d758c02f6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6c0eeb9a-0771-457f-94a4-ff7c08feb741"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("70022040-3cfc-4177-99bb-07e365902467"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7163d5cf-dd74-49f7-9eba-16c13ac2c8ab"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("76fc645a-9d75-4281-86b9-a332a6ed6c94"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("77017673-39b7-4ca9-9770-44b91605febb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("866112e6-a343-4a27-b50e-4477806ab3a8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8ec654b6-2480-422b-a305-047aec5c77ae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8ecd922d-37bb-4431-a3d1-4015d2186430"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("90c13672-f8ca-4f24-897d-141354db17f4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("96fb8a44-785a-47df-b897-122bba6fd0ae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a971f955-2742-42fe-a1a4-5ab9eb63120f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ad13cf7b-28d9-4eed-ba4a-6a4f40c7f17e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("afa1b54a-4a11-445a-a3e7-2aaddd652aae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b1db6b2f-00ad-4f23-91da-fbc54dbd3aea"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b2204502-05bc-4595-9e51-95eb142213b9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b90e2a11-441d-4238-8628-327fd92da117"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ba8cf908-cc97-4cb2-b74d-d872626f1650"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bbea7c7d-23c1-44d4-93e9-dc8e550fcad3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c71ff570-3503-4374-a716-1e2e7d39ee01"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c7774954-bdcc-4819-a9b2-c6457c0e5b0a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cad37dc0-1c08-4795-893f-72c9333f3335"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cf269ab6-f12f-4a95-9318-200c151588ca"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cfc39fb6-3816-42ab-b76a-28a4043f262e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cfdbe34e-f42a-48b6-87ab-0937ab8227fb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d6eae82d-0620-4b90-9dff-ff62945dbb89"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d9e13efc-dd1c-4e57-b09c-07365525d73a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dd33950f-d363-4804-9463-329edd2decf8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ddb20565-2b52-42fd-a60d-cf136c710d17"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e1ccc00a-94b9-44d6-a840-c009663e8392"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e25426d6-5621-47f7-be14-97154e4d2022"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e3d72e86-7d81-4c7a-8799-8ddd8a764a93"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e53e5b9c-e8fa-4f11-bb9b-48a6fe8d9a61"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e9365da9-7506-4ccb-b24b-22974f173187"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ece91944-a6ce-49f9-aea0-21542bd806de"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f91da06e-c009-40c6-ba2c-4d273bbfc606"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fcb1be71-e3b8-4302-8aa1-a5f68317d483"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("01df5a0b-bbc8-4619-be38-5ec5cec184d7"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("07260b9c-2335-415e-882e-bdbfd5844b7b"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("07ec310e-8341-41c4-a1c5-59d55aee1e13"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("0a856f1d-5092-4c15-bd98-aa03cb1c3c33"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("11e46091-542a-4fd3-8181-f124de17e08f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("13b3204f-ffb5-43f9-945d-0a2e385299d4"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("1a1f3248-052c-4694-87d4-0ffd48c4da04"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("22cb4b44-e807-4492-b04c-6d8492e1f7e6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2e0fcac3-7fea-43c0-b7e3-98644428b229"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2f8c02d5-7882-478e-a05d-fb715f788830"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3320732c-525a-473e-af19-e5ad82a0f64c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("34cdfc41-dc00-47cb-a620-1ee46e55bae3"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("39b530c8-6ae9-4dbb-84be-503535d475a6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3b9e8134-a00b-4330-b7f0-13c122a1d49e"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("4525ba1d-8677-428d-84d2-6b72a93b6865"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("51868f16-fef9-45c9-9db5-2bcc36d91ad8"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("6193bb60-567f-460c-b279-8b1007cd1822"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("6720ea86-a598-4fb3-b71b-333e776436c0"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("6c260729-e694-42f9-808c-48e33ae10361"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("6d7a71a0-d891-4fc1-b58c-08e807423ebc"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("6de5cdfd-96f8-4ea4-9dc5-2a36753d1bff"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("779ccfda-d05f-4996-93e8-37bb889ac889"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("947adc36-7132-49d2-b619-10f5b7de9d1f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("aaf24e8a-baed-4857-aa66-1a504f0e3815"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b49cb677-1113-4fd3-8578-eece2dd4c2fa"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b5fcd0fc-7cc1-4fee-8e5b-d6f5924ffcac"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d56fdd35-3f2d-4fca-81c7-32155b021c05"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d63e989d-9972-4336-8fec-d8536c901ed2"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e0b89eda-66ee-4464-922a-0d02995d11ab"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e8320733-bd59-4d22-8835-301cee37a295"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ed48c3dd-8434-47dd-b2bf-502f5ddd04fe"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ef8e59e2-a504-46ef-b383-ef47f6834d33"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f0eb3c07-af91-490a-9897-886c2ef39b7e"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f614faa3-a038-4074-855b-180fbcfe9a3a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f68c9a70-065f-4077-86d9-4cf5ab9391bb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f6f1292f-71a4-4995-b137-e54be0da8a47"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f9e5a9f6-4431-49ed-a73a-73d93247a0fe"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("fb7440d7-2f6a-4726-9db2-a70d872a31cb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("fd62b6bb-4f75-4f20-a163-cac6362648f2"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Packages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Feature",
                table: "Packages",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Doctors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("525be099-6b93-4889-9384-e986fcd8595a"),
                columns: new[] { "Content", "CreatedAt", "Title" },
                values: new object[] { "I’m 26 weeks exactly tomorrow but I started lactating probably 3 weeks ago. It was small spots at first but now I wake up with both nipples soaked through my shirts. My obgyn says not to worry but I would like to understand why so much so early. Any ideas?", new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(276), "26 week already lactating" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("8081a98b-ec3a-4bd2-965d-063617722541"),
                columns: new[] { "Content", "CreatedAt", "Title" },
                values: new object[] { "My peak was on February 18th, and I ovulated on the 19th. My period was supposed to start on the 1st of this month. Today is March 4th, and I still haven’t gotten my period. However, I have brownish spotting when I pee and wipe, but not every time. I took a pregnancy test this morning, and it came back negative. My BBT has been at 98°F since the 28th. I had white discharge on the 2nd and 3rd. I started the brownish spotting on the morning of 12 DPO.\"", new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(297), "Could be implantation bleeding? anyone have a similar cycle?" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("d53abcd4-5ad4-42cd-b5ac-c00bdbd5191c"),
                columns: new[] { "Content", "CreatedAt", "Title" },
                values: new object[] { "I reached my peak of ovulation on the 8th and BD twice a day alllll month. The day after I’ve had hard super tender nips. (Which I know is usual after ovulation) ever since than my breast have my sore and my nips hurt just as bad. I don’t start my period till the 23rd and I usually pms 5 days prior. Is it possible it’s a symptom? \r\n-ive been taking vitamins and eating as healthy as possible while avoiding caffeine as well", new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(294), "Could it be a sign of early pregnancy or pms?" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5084), "Obstetrician" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5113), "Obstetrician" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5092), "Obstetrician" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                columns: new[] { "CreatedAt", "Specialization" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5120), "Obstetrician" });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                columns: new[] { "CreatedAt", "Duration", "Feature", "Type" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 510, DateTimeKind.Local).AddTicks(8217), 10.0, "Like and comment blogs;Update fetus health record", "Free" });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                columns: new[] { "CreatedAt", "Feature" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 510, DateTimeKind.Local).AddTicks(8224), "All the free features;Generate chart;Book doctor in advance" });

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("0626a94e-0c1e-4b03-a89f-92a80226ef4c"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 },
                    { new Guid("1e87eab6-5884-42b6-ace7-e3596313bf40"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("79174348-a036-4ceb-ad0a-acd060b1559e"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("7aa367e9-c2b2-4438-bcde-76f4b5a73865"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 },
                    { new Guid("918f4a47-8ae7-4a8d-9d09-8a48b12170d6"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("b11caea5-07b2-41f7-ac94-620407396a3e"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("b8b3b7c2-45ef-4841-9f62-b51071868bd9"), "You should have an anomaly scan to examine fetal anatomy.", 18 },
                    { new Guid("cce6a20f-d44b-4972-a06e-0fa9c6bdc2ac"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 },
                    { new Guid("cf4f01c7-b589-4fa5-885a-ece124540629"), "You’re now considered early term. You should have regular monitoring.", 37 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("02940367-9b57-46d7-a655-5dd375107f08"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("0898ce30-75cf-4335-a9e6-182f70827f30"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("0bf7bd5a-c9df-40d9-9a54-0f598dd387c1"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("165a6c55-4bd2-46be-82aa-5c6610b42ca8"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("16ce34b1-6e85-43e3-8ffa-8352bbfaa3e6"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("1b6d2a77-1ff4-4b08-a9b0-125534a24076"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1d2d4cde-aaea-407f-8b8d-4278ffcdc8d1"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("1d659aed-e893-4d8f-a97d-80c72e04bf42"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("20cc8547-7ea9-487e-bf9e-24c20e8486a1"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("2201a05f-5df8-4164-bb63-0a6e50eef621"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("37ad9c65-fc79-4ec4-b132-068243a50594"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("3b93b9ca-eff0-488d-abe2-b548bd747c83"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("46d5da75-67ed-4f41-9038-c0d29347c2ee"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("47a3e3eb-c8e4-4851-90bf-95db676cbb76"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("4d60a1e1-b9e2-4631-9897-37b6164cb437"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("4e127521-c1c2-4242-81ae-b9ab071f9bff"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("51c8f18f-a181-4d09-a1b2-8c63753e1a34"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("525e7d0d-5448-4a87-ac38-38361f54527d"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("533d5632-6245-4998-bad2-1b9ab008d3ce"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5840db7b-adf2-456a-9fd7-5b79fac7cea8"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("5ddb9494-ba0c-4158-bfa3-0ac98e6c0e17"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("5f292a2b-1731-4aa4-92aa-15a47e10f6f0"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("66966a1e-f573-41a9-ac1b-1c818e21af58"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("6793c9d8-67eb-48a2-bfd4-0358692f59e1"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("6baf8a20-e403-4ae9-8977-2c74bc819b2d"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("6be07b6d-d263-4cf0-a37e-9b99e41489ae"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("6befdd5d-03bd-4eec-8184-db9d56336219"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("6e003380-0aed-4450-ac86-d34e6a09f430"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("71f16a86-0dc4-4438-bf51-cf908fe5a098"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("76d9d022-d36a-427e-9fb6-26caf9030be7"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("79b46bdf-9513-4e9f-af75-9d0a690e393f"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("80f53f34-511d-4016-bb97-426b78067e5e"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("869b7901-4d1e-4354-b8c3-743f43b34af8"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("874444a8-efea-4d67-af5d-a6ccd4b7e288"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("9bf27509-a61a-4f2b-ac38-ebabe0fb9e6a"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("a433a6ee-a9fd-41d8-9eff-318030efe94b"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("a49b9656-b137-4fa9-b248-4264a425c06b"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("a621731e-95e9-43a5-814d-8597f966dfd0"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("a63f400b-be6c-46da-8d8b-7261a7fce8b2"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("b01abc9c-57a4-443c-a3f1-54192ec92bdc"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("b3a36e1a-fdc2-4874-9e79-427f3893c0e4"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("b939351c-6e50-4c0d-95bc-3c4729335538"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("bf6bfcfe-e224-4384-b977-0e99d00e82cb"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c00cce24-c382-4873-9c88-167c59828f38"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c05debcb-e0de-4a96-bbb7-2fff43af554e"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("c5070e07-3865-402c-9cee-39705797a9f3"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c5f9abba-dce3-4c7c-b490-1ce8973ad8cd"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c7762427-305c-4149-a152-239205fae052"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("c86ef861-8249-4b62-8f41-fabc4a8c2b33"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("cf67cd21-3b67-488b-91db-e9a5f84db162"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("d02e4cd1-e32f-4209-8260-bb3defeeb6a9"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("d82be5b0-cd5a-4ea7-b240-10d52352e343"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("dd6a5396-d3b7-49c1-8cf8-0e408a9f967f"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("de324f31-c462-4860-9126-454b7fc729f8"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e0516533-2b76-4064-81d2-303789caeb27"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e05f1d38-417d-45c8-a33c-bd90c4864798"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("e1aa703c-1dda-402e-9fe6-f5305aefdb09"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e60d2512-a6dc-4daa-b915-56465f8181a0"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e6316b0f-f73b-49e4-8992-6ab6675d48da"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e78525f2-608b-424b-85d9-44f32085e241"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("ed36d74b-4ea0-427e-a370-39b976b3b1e3"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("f6dd4e39-6115-4bf1-b246-c813f339f752"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("fdca5a10-b4cf-4e1f-a2e8-97ef1d4f2c78"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("fe8ab826-c5ae-4ae7-9d77-53be7a50ebe0"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("05dd1e97-432a-46a7-bbad-a286486ee2ee"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 21 },
                    { new Guid("0bd302ec-ee8a-4c94-b418-20a3ba198dcc"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("0f6364da-8523-4f9f-8526-085ae467b6cf"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 17 },
                    { new Guid("1ac1af94-4ce8-4745-a00b-34b5cc122104"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 13 },
                    { new Guid("231df9a7-78f7-4eb1-aeca-b086fc17e5f7"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 33 },
                    { new Guid("30e14770-a38b-4911-a52e-a06af2836061"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 11 },
                    { new Guid("33df37f1-7141-4581-81c7-e24e34b81e02"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 19 },
                    { new Guid("343e20cb-110c-4e8e-b294-d6436c0e527a"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("38905c51-bad2-4eab-8660-ed4e372bb3fa"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 25 },
                    { new Guid("3f5e4b9f-696d-45f9-b255-ce82ab578193"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("441babce-0ac5-4a81-87ac-8cc146e753e2"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 27 },
                    { new Guid("46b04f89-f850-4843-b210-fd2e6cafa518"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("46bfe5b5-e6aa-4ec2-89cf-cc7077c51fa6"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("48d169f8-ec3c-4db2-8d18-f1a43e375741"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("51126d77-871e-4842-ae5d-c6ab0e19378a"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 35 },
                    { new Guid("51224f66-5f65-4ed7-a08f-11ff3dd527da"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("5641bf64-092c-4ea3-990a-a146cd2e2c6d"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("5f157f94-732f-47f7-978e-9864e6bd4627"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("60823d3e-ef74-4ee3-8686-0b3f582751fe"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("60d5c0dc-faf4-4ba0-8a1a-662709efb641"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("650b2907-496a-4a86-8951-589d87bd7a8d"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 31 },
                    { new Guid("666045cf-38a8-4502-a557-c9d0915ca859"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("7c2eae5a-9e12-4ebb-b492-bfeb79fc1304"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 39 },
                    { new Guid("8020a5bf-bd01-4958-9e17-64264a3ddb8a"), null, null, null, null, null, null, null, null, 2 },
                    { new Guid("9573452b-683b-4170-992b-5ab059e89bd6"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("a984a5c5-c252-4591-a549-a5b109b73df5"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 23 },
                    { new Guid("aae2b927-72ef-492c-88db-fc979d275dde"), null, null, null, null, null, null, null, null, 4 },
                    { new Guid("b1195917-fab4-494c-9204-32296938657c"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("bd659b1f-2673-40c9-a648-dae1b6184a01"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("c260167c-c915-4f76-a112-780878cc9add"), null, null, null, null, null, null, null, null, 5 },
                    { new Guid("c97d1d98-5fcb-4b42-96df-90ace5ced451"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("e329809c-6b87-4c79-9ce3-91ea11f6f269"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("e49bf254-c814-489f-9561-93a39abbe664"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 37 },
                    { new Guid("e9567102-ed2c-477d-b279-31adbe88cac5"), null, null, null, null, null, null, null, null, 3 },
                    { new Guid("e997a352-e80f-4777-8de5-11ae87ff3a7c"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("ed1ce099-c9bd-462f-bcd3-7de40b7740d6"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 15 },
                    { new Guid("f07a039e-5a76-4e35-900f-cbf1692bb12c"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 29 },
                    { new Guid("f2f82f06-cb3c-4e3e-88eb-003f2d79012d"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 },
                    { new Guid("f7dd6207-b132-4ce0-91b6-8919491586cd"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 }
                });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("05ac02ec-3fd0-47ad-ab14-4a969bec6e3d"),
                column: "Name",
                value: "Parenting");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3185dbf9-c4be-4c0e-b8e6-4d9ee47bb296"),
                column: "Name",
                value: "Mental Health");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd"),
                column: "Name",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8e18a540-ce22-46d3-ba7b-cde9d20dca38"),
                column: "Name",
                value: "Exercise");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bc557eef-49f8-4bca-8f0a-9700b8c13e7e"),
                column: "Name",
                value: "Nutrition");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d1a17f1e-eb54-43bc-bdac-ca1873c99362"),
                column: "Name",
                value: "Pregnancy");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d5aefed2-5df7-4d2f-bec4-7932da2849de"),
                column: "Name",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"),
                columns: new[] { "CCCD", "CreatedAt", "Email", "FullName", "Password", "Username" },
                values: new object[] { "082202000012", new DateTime(2025, 3, 16, 13, 36, 52, 568, DateTimeKind.Local).AddTicks(5913), "tannghiepnguyen123@gmail.com", "Nguyen Le Tan Nghiep", "AQAAAAIAAYagAAAAELeIbNYMWToYoibF0r6q0qjtLe84qPkpEVuQS1QzlAovM+HSHhyw7QI0ojmOJKL9Qg==", "tannghiep" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 512, DateTimeKind.Local).AddTicks(7313), "AQAAAAIAAYagAAAAEFEEyxRURzxVYxRpKSEidp0QiKS7PzqOgiCJo4fPCueAUz1FNxBGFa1k8c4yhLR2wQ==" });
        }
    }
}
