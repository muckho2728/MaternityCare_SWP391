using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStandardFetushealth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("043a540d-2582-4433-8014-827836d4f9ac"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("6f1ef3da-0e40-4d55-9591-c56f3196b2a0"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("78e56da5-8949-4edb-bb8e-77c7c272ed95"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("78e60773-2d68-4f3f-ae17-63cc39f2481b"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("7c51a5d3-163a-488e-8351-f3177a12f706"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("8f20462d-d13c-490a-9f15-0061182a6d05"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("93adc9a5-df94-481e-9b3a-2fd9cffe0814"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("ce3fbe6c-87d4-4623-912d-7b900968b521"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("f9ad0ce6-a441-4ec7-b472-176803d87457"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("00b6539c-5b9f-4098-8035-f93d46eb5424"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("02300947-6d92-4399-b132-cae490c15f11"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("025be50f-b0cb-4225-a069-f4ac39b4ddf8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("06217215-ea27-4a67-a63f-f973c8794bf2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("17d0a12d-6de6-4f8a-a22c-8eff07662940"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1e191e08-d3ad-4a91-ad6c-d52eaaf66044"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1fd95b8d-a90a-4807-9b23-717ba77eae62"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("21103c13-89a2-4ab0-a241-bdd40d72ef0a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("25516d98-0db9-4127-b5ef-54193739bad0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2c8ab3dd-8b59-49b4-aeb6-a089e2a096a4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("34098302-4eed-4188-932f-c63e536cb99f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("34835f4e-0447-4fb5-ae1a-c4df41f050e7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3cf2e8da-38b6-4da6-8c26-de47d040bef6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("434d5747-fc35-4e40-b20d-ff2748679eb4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4a41f146-dc48-4128-9979-0ee1b04f7deb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4a70e437-2e0e-4032-bcc1-be102ca829fa"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4f2668a2-db8f-49ae-9089-48b9dd13e568"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("52ed22d9-86e5-4490-84b0-d6f95653ad7b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5b4149ab-d5b3-4fa1-b366-322599b3ac11"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5ca42f68-c056-4e8f-8aec-926897804757"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5ef8c065-8bac-40c4-bb9e-2489709b7b16"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5f9156ae-aa95-411a-98d3-7e32904ca672"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("61a95691-ac8a-434b-beb5-42432eed65c1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("68f4d390-418b-47e7-bc33-42db3a83e88c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6c4b7075-b479-4a61-97f6-b39fe64aebd2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6d596ffe-f8e9-4470-9fea-1d39a67fdb85"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7435f941-2025-4785-a0aa-3ef982a32078"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("77782e38-2902-4527-93b1-909fb4728390"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7e561c1d-289c-4966-8300-d5459b7f27f2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("80b4735d-009e-4b42-a02f-e85f36f1686c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("80e15b55-9851-4551-92c9-b39d8516bf01"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("81be1939-e836-43b0-91c1-4c8c7a5eba6a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8db9926d-d351-46e1-a5a4-b430804a673b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8f1336de-cc91-4d73-84f4-7090faed854c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9bf20116-da75-4eb4-af05-0d1f1714323f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9d1373ce-829d-4216-a2dd-7a33743ad933"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9e78ced9-8f21-4884-b959-5fa3bd6c8e65"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a3992574-87e9-4b8a-9cbc-1b62b24648fe"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a54ffd2d-7d04-43b0-947e-bb81bba14c35"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a8ac3823-8251-4081-9de1-40b6f8993e46"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("aa51ba4d-5ad3-4660-bd38-a4d66ac46130"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b0b0706d-eb94-4c5d-82b4-d2a6d42a1c0f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b436ea7e-d503-44ec-9987-a5eb242e8d4f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b85ebb49-3059-4fee-b93e-bef0aa378090"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b8fcecbb-a3fa-4594-a66a-8706eb020b40"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bacf9489-a577-4955-a522-faed67211ad0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bc7bcdae-6ab9-4277-b954-d0c2d05fd47b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("be1795d1-06d8-4d1a-a551-e85a11c9ca2e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c342b5bc-2737-466e-9911-b0c55a6c4211"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c6e2150b-a9c8-4951-8cd0-1824fc66c51a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c8861c1b-101a-4efb-92f7-23bc5911e4df"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d14ab618-13e8-42b1-b8d2-a233e7eab46e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d3796517-e82a-4b4e-91bf-f6cbe6bce3fe"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d45a75bf-2f92-4c2e-a07f-9e52a26ac3ef"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d79a3bbe-6688-472a-919a-f459aa85eabd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d7f9899e-f63b-4e4e-930b-a1fbb552d7e4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dcc4cdfb-e6bf-4a83-9dce-42e237d2f6a5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dd97809b-c2f2-4f2c-ba61-1e461f4412d9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e7b521d4-b048-40f1-b470-7f04f5a6dcd5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f07bd02e-a650-49ec-b135-96689bf088ad"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f1fb76b9-60db-451c-95ca-96f0c1a0b6e9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f266648d-9702-4c29-bfa6-85dea52a1d3c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f42bfe09-849a-4447-b1e8-28d9053946e8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fb8efbab-a416-4ae4-9d3e-dc12ed4d3d8a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("06ede5ac-c062-4d2f-b7e9-fb45037e52e3"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("1cf13ce2-a45e-46c2-ac71-8f9fc2e13258"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("1e7e8311-437a-409a-868b-e396c6fbbb35"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2567632b-b209-4bfb-ab61-45caeacfb60a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3c7b60e9-2d24-4292-a6c7-01a1c6a2b02a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3eb6585b-8927-4898-b664-63ec2b7f757d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("41468045-a042-4b04-b939-47527ecf3f2e"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("51a7e6f6-c101-4133-b131-96adaedea5b4"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("53262075-8412-49ef-ab68-b0ef165f58c0"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5809b410-3a93-44b0-affa-b3380383a631"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("61620db3-7716-423c-ab72-e2709a8d3936"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("67272a92-13d9-4d38-8046-7b5e9c890840"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7bd43059-69b6-470d-867d-2e66c9188b98"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8567aae2-1a88-4f67-9795-6ae33d0876e8"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("85b336e3-9ca7-4d5b-8bde-c339a6408d27"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8e524de0-81a6-4b48-850a-1488289db21b"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ab0fd326-01f1-4419-9eb3-f8bc8772f34d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b14fe439-9de4-42af-a7dc-1802f5092b0f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d38c51c1-80e2-4c61-b648-70ac6c7810a9"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e1baa4e4-422c-4511-87c4-a0ce4c54da2e"));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 20, 29, 707, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 20, 29, 707, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 20, 29, 707, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 20, 29, 707, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 20, 29, 709, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 13, 20, 29, 709, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("15a8990d-b785-4dcb-8116-3289c1925928"), "You’re now considered early term. You should have regular monitoring.", 37 },
                    { new Guid("15f421ca-7cc5-4a52-94fa-6b25d28e7515"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("16665d5f-ac2c-43a3-9f55-988eb44cb1ed"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("1ea0c0f3-d8f0-4ff0-b86e-6883fadc6179"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("97de3104-ae1b-479b-884d-5d76959896ed"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 },
                    { new Guid("98e613a9-6b45-473f-91e1-00dcbffad420"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("b1c3bef1-5e5d-42c3-97b5-2e8831a20bcc"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 },
                    { new Guid("b1f74945-c7ba-4021-a423-690db8eedaba"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 },
                    { new Guid("e98b27f1-bc6a-4aba-9b73-02b6669c6ad8"), "You should have an anomaly scan to examine fetal anatomy.", 18 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("0157ea78-84be-4fb8-9a61-0258e8e1ae88"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("041d34ce-5b9b-42e5-8990-a87ff46a1b38"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("0bb30086-9a9f-4047-b522-a605c30edae9"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("11799cd7-074e-437f-89dc-7261a2c32085"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("1521706a-30da-4148-8bfe-292d4bc1f8dd"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1977d531-153b-49f4-a0bf-04d0d2b2c0e8"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("1cec85c8-8ae7-4acf-8b79-39d973e58a23"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1d03c197-66c8-4603-a2eb-0d00787f119e"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("1d1c8b74-fc8c-47f8-8f16-9a0153115842"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("20683083-6fd6-4b93-b6e3-8cd02ef06c99"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("26903565-5e05-49e0-81cc-f9428d47d821"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("2ab027af-c3cf-4781-afcf-b26d281c6d4a"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("2b6dd744-3ea6-42a6-8ac5-208d7d3a49dd"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("2b75e2cb-d5e6-4fc0-9744-e83e82083fa0"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("2dcd9b7c-dee6-436c-bbe7-6788fc7c3b65"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("2eb8f0cc-bdb9-453c-a4bb-ada3b318e6cb"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("30037b80-4aec-4d43-9865-b40406b24e88"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("3216144f-fe80-41a2-8a7e-646c655fda57"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("363790b0-2c39-4630-ae51-18f9a001b7e8"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("3950ab1c-3424-44a8-b503-c012749bbcac"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("3d13c29a-a0a7-4508-b669-0a7d300848f7"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("3f65bbcc-707f-4ed6-b007-fa143cae30b4"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("48007db6-7b2e-4d4a-a413-71f2d178dd7a"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("4d6345df-2572-42be-b1d9-210529f8e787"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("4ead7441-5667-47ce-907d-90b58d00bdc5"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("56515def-f498-4bd9-840c-fc5cac429858"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("592c1402-a03e-40bd-a04f-b8738feda86a"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("6bdcd263-af44-48f8-ba3a-ee072c575b01"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("77d90973-3ca2-43e8-aaa0-305a4c99cfbd"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("7a7c520f-4a68-4aa8-ac77-c96eefb6711f"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("7b1e6c47-3ca9-4c8d-b3dc-b4f591d0a5f6"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("7d7c4496-a8d8-448f-98b1-c133cbbc9b39"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("7dba7387-1c43-420c-a40d-faf2665f768c"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("844c57bd-1471-4cc6-bb6a-d64ff7631a55"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("84b0160d-8121-4e2a-9b60-a7f12248d436"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("8983c558-80df-4ddb-8944-61a8e5f27a2d"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("92c180ab-26b7-4324-ac64-4b69f07cada3"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("9368f98b-0413-4b1b-b5b3-5712c3394e20"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("967595cb-587b-4370-ad4d-ef8df602df5c"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("9740fa2d-d4cb-470c-af6f-757ae7007df4"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("98a7891a-f220-4670-9020-929599e817ab"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("9aee904b-b9bd-4a89-b83a-f7e45b09a28b"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("9f8d090a-a069-49b7-b6fb-8ee9c539d9b7"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("a2a88c62-d403-41ba-bfe2-1e16e64d7bf5"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("a7be8732-8d14-4397-a1f0-3f045c28dd55"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("a7ce0c34-349f-4cd5-b0bc-0a1bc800e0cf"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("a8651737-d06a-4eaa-a930-5c22a34dc00b"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("bb92ede6-fd5f-498f-bb17-6420a1ebacb9"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("be3b31c4-1710-43c4-8a75-a9ba69dc2f33"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("c5ad3576-c9f1-49ee-93c0-1b1e4410ebf5"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c79128cd-7a8f-41de-bbe3-f306b90fc9e8"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c993df37-58a1-498a-81a6-55152403d623"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("cb0da4e9-1c86-4f26-bae8-60f592571527"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("cb6b401e-6ef3-4eed-8fc3-fc2475447c38"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("d5d356ec-d2ab-4774-a8f9-6439f3b4f3b6"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("db5cffb7-c33d-4420-a5b3-ecf69387bbb6"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("dd2c9efd-fcbf-4f49-996c-74b3b2b3db02"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("ddbee333-1466-400b-adfc-0f1500b6101c"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("e3e27a58-7cc2-4fa7-b804-59acab5bf3d6"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("ed2df40a-16ee-4ed8-be99-4a01e9c14742"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f0619999-2dc0-4cc8-a9b2-524f4df79087"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("f32c666c-fe25-454b-9c2f-0839c1ddc773"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("f7630373-d516-4033-9d6a-cbb3a1bbcae9"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f9a3c6cd-da44-410c-aaeb-0c5885094afc"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("07cce7a7-aec5-4efc-bec7-af1f208f5abb"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 27 },
                    { new Guid("24e36a90-10d7-4410-b1eb-4e687ab25f26"), null, null, null, null, null, null, null, null, 3 },
                    { new Guid("3caf42e0-4a0f-4ce4-991f-4dc8ee225975"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("3fa020df-eccb-48a6-8fbd-858a9256883f"), null, null, null, null, null, null, null, null, 2 },
                    { new Guid("46c146a4-cbba-496e-b00f-bc88fdaecd5b"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("49ae748f-751e-4d33-8355-b5b41568e279"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 37 },
                    { new Guid("4bd00f6b-06b3-439b-99a6-605225f16e74"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("549908bb-337f-4008-bdf5-a9cd63fe4bb8"), null, null, null, null, null, null, null, null, 4 },
                    { new Guid("5e4f3925-b1fc-40f8-979f-e3de7223b56a"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("6106fec3-a3a3-4738-9b45-d9ab9991a716"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("63eaf76a-26ab-4d6d-936a-9377bd12fcf7"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 },
                    { new Guid("79947efe-4102-4ef5-b754-57dd033df5bb"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("7ab6e38c-ba72-439f-8dbe-b335050b22e1"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 19 },
                    { new Guid("7c6c0206-c04a-491d-8cbd-4ea7dc1a3abc"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 23 },
                    { new Guid("82bfc986-0773-4f8f-a882-c3e170e62eea"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("86b0bd6b-eca3-4b7e-9a51-4880e0cbe19b"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("8a968e81-6b47-46f1-b744-b8c160a402e6"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 25 },
                    { new Guid("8fa6e593-937c-4a75-8a49-2ed452adf821"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("920ee2b6-0e9d-4c00-949e-7dd72cbac485"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("96abfa89-ccd9-4791-84ad-9500004f058d"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 31 },
                    { new Guid("9897c495-9347-4c03-9641-05831e2d9470"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 33 },
                    { new Guid("9ea48cc1-ad3e-4bbf-9d9a-8c2d04815436"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 17 },
                    { new Guid("a2c07d66-641d-4aa7-b2a9-85887b1a7124"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("a6f067d3-c380-4e72-a5b1-93f0300a3b80"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("b41aaade-6533-4395-bc64-6761d0015871"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 21 },
                    { new Guid("b9834ede-96f7-49f8-841b-830338c4948f"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("bba903e4-7836-4e69-ba0b-e89135956eff"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 29 },
                    { new Guid("c0eb3587-a75c-4c69-b6a6-6e06860ec56d"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 11 },
                    { new Guid("c5c479ef-7c41-4271-8ffe-38646f6f8b1b"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 35 },
                    { new Guid("c8e4bf67-ce77-43d3-8e0b-16885a0d1bb6"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("ccecf738-a836-4d65-99a8-cc5ece8e2c51"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("d588831e-1221-4b7a-b59e-da18e7fb90f1"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 13 },
                    { new Guid("d83cc79d-03a9-4d7f-a8c7-8cbda979c47f"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("db279870-3aa4-437b-964d-45ff701c66d6"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 39 },
                    { new Guid("e6c20b2b-d8a6-4635-a37f-ea78678f1a41"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("e95ecc01-2f62-4714-8311-23759c4dc70a"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("ec12c059-4b2f-4f55-85e7-af81a34e54d1"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("f8c9b09c-fe7d-4f29-bcf9-c193c17d6ca7"), null, null, null, null, null, null, null, null, 5 },
                    { new Guid("fab0c107-a458-43c0-b128-06aca22b1b63"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 3, 5, 13, 20, 29, 711, DateTimeKind.Local).AddTicks(3862), "AQAAAAIAAYagAAAAED371fTKfsG0rpE++t3cq6VnJHsVN/NRbJCVLrtfNjPWraJ00Gm9bupSd2Ny3q24aQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("15a8990d-b785-4dcb-8116-3289c1925928"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("15f421ca-7cc5-4a52-94fa-6b25d28e7515"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("16665d5f-ac2c-43a3-9f55-988eb44cb1ed"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("1ea0c0f3-d8f0-4ff0-b86e-6883fadc6179"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("97de3104-ae1b-479b-884d-5d76959896ed"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("98e613a9-6b45-473f-91e1-00dcbffad420"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("b1c3bef1-5e5d-42c3-97b5-2e8831a20bcc"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("b1f74945-c7ba-4021-a423-690db8eedaba"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("e98b27f1-bc6a-4aba-9b73-02b6669c6ad8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0157ea78-84be-4fb8-9a61-0258e8e1ae88"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("041d34ce-5b9b-42e5-8990-a87ff46a1b38"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0bb30086-9a9f-4047-b522-a605c30edae9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("11799cd7-074e-437f-89dc-7261a2c32085"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1521706a-30da-4148-8bfe-292d4bc1f8dd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1977d531-153b-49f4-a0bf-04d0d2b2c0e8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1cec85c8-8ae7-4acf-8b79-39d973e58a23"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1d03c197-66c8-4603-a2eb-0d00787f119e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1d1c8b74-fc8c-47f8-8f16-9a0153115842"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("20683083-6fd6-4b93-b6e3-8cd02ef06c99"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("26903565-5e05-49e0-81cc-f9428d47d821"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2ab027af-c3cf-4781-afcf-b26d281c6d4a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2b6dd744-3ea6-42a6-8ac5-208d7d3a49dd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2b75e2cb-d5e6-4fc0-9744-e83e82083fa0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2dcd9b7c-dee6-436c-bbe7-6788fc7c3b65"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2eb8f0cc-bdb9-453c-a4bb-ada3b318e6cb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("30037b80-4aec-4d43-9865-b40406b24e88"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3216144f-fe80-41a2-8a7e-646c655fda57"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("363790b0-2c39-4630-ae51-18f9a001b7e8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3950ab1c-3424-44a8-b503-c012749bbcac"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3d13c29a-a0a7-4508-b669-0a7d300848f7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3f65bbcc-707f-4ed6-b007-fa143cae30b4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("48007db6-7b2e-4d4a-a413-71f2d178dd7a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4d6345df-2572-42be-b1d9-210529f8e787"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4ead7441-5667-47ce-907d-90b58d00bdc5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("56515def-f498-4bd9-840c-fc5cac429858"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("592c1402-a03e-40bd-a04f-b8738feda86a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6bdcd263-af44-48f8-ba3a-ee072c575b01"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("77d90973-3ca2-43e8-aaa0-305a4c99cfbd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7a7c520f-4a68-4aa8-ac77-c96eefb6711f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7b1e6c47-3ca9-4c8d-b3dc-b4f591d0a5f6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7d7c4496-a8d8-448f-98b1-c133cbbc9b39"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7dba7387-1c43-420c-a40d-faf2665f768c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("844c57bd-1471-4cc6-bb6a-d64ff7631a55"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("84b0160d-8121-4e2a-9b60-a7f12248d436"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8983c558-80df-4ddb-8944-61a8e5f27a2d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("92c180ab-26b7-4324-ac64-4b69f07cada3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9368f98b-0413-4b1b-b5b3-5712c3394e20"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("967595cb-587b-4370-ad4d-ef8df602df5c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9740fa2d-d4cb-470c-af6f-757ae7007df4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("98a7891a-f220-4670-9020-929599e817ab"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9aee904b-b9bd-4a89-b83a-f7e45b09a28b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9f8d090a-a069-49b7-b6fb-8ee9c539d9b7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a2a88c62-d403-41ba-bfe2-1e16e64d7bf5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a7be8732-8d14-4397-a1f0-3f045c28dd55"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a7ce0c34-349f-4cd5-b0bc-0a1bc800e0cf"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a8651737-d06a-4eaa-a930-5c22a34dc00b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("bb92ede6-fd5f-498f-bb17-6420a1ebacb9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("be3b31c4-1710-43c4-8a75-a9ba69dc2f33"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c5ad3576-c9f1-49ee-93c0-1b1e4410ebf5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c79128cd-7a8f-41de-bbe3-f306b90fc9e8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c993df37-58a1-498a-81a6-55152403d623"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cb0da4e9-1c86-4f26-bae8-60f592571527"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cb6b401e-6ef3-4eed-8fc3-fc2475447c38"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d5d356ec-d2ab-4774-a8f9-6439f3b4f3b6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("db5cffb7-c33d-4420-a5b3-ecf69387bbb6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dd2c9efd-fcbf-4f49-996c-74b3b2b3db02"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ddbee333-1466-400b-adfc-0f1500b6101c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e3e27a58-7cc2-4fa7-b804-59acab5bf3d6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ed2df40a-16ee-4ed8-be99-4a01e9c14742"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f0619999-2dc0-4cc8-a9b2-524f4df79087"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f32c666c-fe25-454b-9c2f-0839c1ddc773"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f7630373-d516-4033-9d6a-cbb3a1bbcae9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f9a3c6cd-da44-410c-aaeb-0c5885094afc"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("07cce7a7-aec5-4efc-bec7-af1f208f5abb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("24e36a90-10d7-4410-b1eb-4e687ab25f26"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3caf42e0-4a0f-4ce4-991f-4dc8ee225975"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3fa020df-eccb-48a6-8fbd-858a9256883f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("46c146a4-cbba-496e-b00f-bc88fdaecd5b"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("49ae748f-751e-4d33-8355-b5b41568e279"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("4bd00f6b-06b3-439b-99a6-605225f16e74"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("549908bb-337f-4008-bdf5-a9cd63fe4bb8"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5e4f3925-b1fc-40f8-979f-e3de7223b56a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("6106fec3-a3a3-4738-9b45-d9ab9991a716"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("63eaf76a-26ab-4d6d-936a-9377bd12fcf7"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("79947efe-4102-4ef5-b754-57dd033df5bb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7ab6e38c-ba72-439f-8dbe-b335050b22e1"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7c6c0206-c04a-491d-8cbd-4ea7dc1a3abc"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("82bfc986-0773-4f8f-a882-c3e170e62eea"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("86b0bd6b-eca3-4b7e-9a51-4880e0cbe19b"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8a968e81-6b47-46f1-b744-b8c160a402e6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8fa6e593-937c-4a75-8a49-2ed452adf821"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("920ee2b6-0e9d-4c00-949e-7dd72cbac485"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("96abfa89-ccd9-4791-84ad-9500004f058d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("9897c495-9347-4c03-9641-05831e2d9470"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("9ea48cc1-ad3e-4bbf-9d9a-8c2d04815436"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("a2c07d66-641d-4aa7-b2a9-85887b1a7124"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("a6f067d3-c380-4e72-a5b1-93f0300a3b80"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b41aaade-6533-4395-bc64-6761d0015871"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b9834ede-96f7-49f8-841b-830338c4948f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("bba903e4-7836-4e69-ba0b-e89135956eff"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c0eb3587-a75c-4c69-b6a6-6e06860ec56d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c5c479ef-7c41-4271-8ffe-38646f6f8b1b"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c8e4bf67-ce77-43d3-8e0b-16885a0d1bb6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ccecf738-a836-4d65-99a8-cc5ece8e2c51"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d588831e-1221-4b7a-b59e-da18e7fb90f1"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d83cc79d-03a9-4d7f-a8c7-8cbda979c47f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("db279870-3aa4-437b-964d-45ff701c66d6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e6c20b2b-d8a6-4635-a37f-ea78678f1a41"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e95ecc01-2f62-4714-8311-23759c4dc70a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ec12c059-4b2f-4f55-85e7-af81a34e54d1"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f8c9b09c-fe7d-4f29-bcf9-c193c17d6ca7"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("fab0c107-a458-43c0-b128-06aca22b1b63"));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 22, 52, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 22, 52, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 22, 52, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 22, 52, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 22, 55, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 22, 55, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("043a540d-2582-4433-8014-827836d4f9ac"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("6f1ef3da-0e40-4d55-9591-c56f3196b2a0"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("78e56da5-8949-4edb-bb8e-77c7c272ed95"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 },
                    { new Guid("78e60773-2d68-4f3f-ae17-63cc39f2481b"), "You’re now considered early term. You should have regular monitoring.", 37 },
                    { new Guid("7c51a5d3-163a-488e-8351-f3177a12f706"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 },
                    { new Guid("8f20462d-d13c-490a-9f15-0061182a6d05"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("93adc9a5-df94-481e-9b3a-2fd9cffe0814"), "You should have an anomaly scan to examine fetal anatomy.", 18 },
                    { new Guid("ce3fbe6c-87d4-4623-912d-7b900968b521"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("f9ad0ce6-a441-4ec7-b472-176803d87457"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("00b6539c-5b9f-4098-8035-f93d46eb5424"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("02300947-6d92-4399-b132-cae490c15f11"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("025be50f-b0cb-4225-a069-f4ac39b4ddf8"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("06217215-ea27-4a67-a63f-f973c8794bf2"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("17d0a12d-6de6-4f8a-a22c-8eff07662940"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1e191e08-d3ad-4a91-ad6c-d52eaaf66044"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("1fd95b8d-a90a-4807-9b23-717ba77eae62"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("21103c13-89a2-4ab0-a241-bdd40d72ef0a"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("25516d98-0db9-4127-b5ef-54193739bad0"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("2c8ab3dd-8b59-49b4-aeb6-a089e2a096a4"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("34098302-4eed-4188-932f-c63e536cb99f"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("34835f4e-0447-4fb5-ae1a-c4df41f050e7"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("3cf2e8da-38b6-4da6-8c26-de47d040bef6"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("434d5747-fc35-4e40-b20d-ff2748679eb4"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("4a41f146-dc48-4128-9979-0ee1b04f7deb"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("4a70e437-2e0e-4032-bcc1-be102ca829fa"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("4f2668a2-db8f-49ae-9089-48b9dd13e568"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("52ed22d9-86e5-4490-84b0-d6f95653ad7b"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5b4149ab-d5b3-4fa1-b366-322599b3ac11"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("5ca42f68-c056-4e8f-8aec-926897804757"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5ef8c065-8bac-40c4-bb9e-2489709b7b16"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("5f9156ae-aa95-411a-98d3-7e32904ca672"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("61a95691-ac8a-434b-beb5-42432eed65c1"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("68f4d390-418b-47e7-bc33-42db3a83e88c"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("6c4b7075-b479-4a61-97f6-b39fe64aebd2"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("6d596ffe-f8e9-4470-9fea-1d39a67fdb85"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("7435f941-2025-4785-a0aa-3ef982a32078"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("77782e38-2902-4527-93b1-909fb4728390"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("7e561c1d-289c-4966-8300-d5459b7f27f2"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("80b4735d-009e-4b42-a02f-e85f36f1686c"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("80e15b55-9851-4551-92c9-b39d8516bf01"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("81be1939-e836-43b0-91c1-4c8c7a5eba6a"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("8db9926d-d351-46e1-a5a4-b430804a673b"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("8f1336de-cc91-4d73-84f4-7090faed854c"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("9bf20116-da75-4eb4-af05-0d1f1714323f"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("9d1373ce-829d-4216-a2dd-7a33743ad933"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("9e78ced9-8f21-4884-b959-5fa3bd6c8e65"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("a3992574-87e9-4b8a-9cbc-1b62b24648fe"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("a54ffd2d-7d04-43b0-947e-bb81bba14c35"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("a8ac3823-8251-4081-9de1-40b6f8993e46"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("aa51ba4d-5ad3-4660-bd38-a4d66ac46130"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("b0b0706d-eb94-4c5d-82b4-d2a6d42a1c0f"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b436ea7e-d503-44ec-9987-a5eb242e8d4f"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b85ebb49-3059-4fee-b93e-bef0aa378090"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("b8fcecbb-a3fa-4594-a66a-8706eb020b40"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("bacf9489-a577-4955-a522-faed67211ad0"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("bc7bcdae-6ab9-4277-b954-d0c2d05fd47b"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("be1795d1-06d8-4d1a-a551-e85a11c9ca2e"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c342b5bc-2737-466e-9911-b0c55a6c4211"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c6e2150b-a9c8-4951-8cd0-1824fc66c51a"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("c8861c1b-101a-4efb-92f7-23bc5911e4df"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("d14ab618-13e8-42b1-b8d2-a233e7eab46e"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("d3796517-e82a-4b4e-91bf-f6cbe6bce3fe"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("d45a75bf-2f92-4c2e-a07f-9e52a26ac3ef"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("d79a3bbe-6688-472a-919a-f459aa85eabd"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("d7f9899e-f63b-4e4e-930b-a1fbb552d7e4"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("dcc4cdfb-e6bf-4a83-9dce-42e237d2f6a5"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("dd97809b-c2f2-4f2c-ba61-1e461f4412d9"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("e7b521d4-b048-40f1-b470-7f04f5a6dcd5"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("f07bd02e-a650-49ec-b135-96689bf088ad"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f1fb76b9-60db-451c-95ca-96f0c1a0b6e9"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("f266648d-9702-4c29-bfa6-85dea52a1d3c"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("f42bfe09-849a-4447-b1e8-28d9053946e8"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("fb8efbab-a416-4ae4-9d3e-dc12ed4d3d8a"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("06ede5ac-c062-4d2f-b7e9-fb45037e52e3"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("1cf13ce2-a45e-46c2-ac71-8f9fc2e13258"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("1e7e8311-437a-409a-868b-e396c6fbbb35"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("2567632b-b209-4bfb-ab61-45caeacfb60a"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 },
                    { new Guid("3c7b60e9-2d24-4292-a6c7-01a1c6a2b02a"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("3eb6585b-8927-4898-b664-63ec2b7f757d"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("41468045-a042-4b04-b939-47527ecf3f2e"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("51a7e6f6-c101-4133-b131-96adaedea5b4"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("53262075-8412-49ef-ab68-b0ef165f58c0"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("5809b410-3a93-44b0-affa-b3380383a631"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("61620db3-7716-423c-ab72-e2709a8d3936"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("67272a92-13d9-4d38-8046-7b5e9c890840"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("7bd43059-69b6-470d-867d-2e66c9188b98"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("8567aae2-1a88-4f67-9795-6ae33d0876e8"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("85b336e3-9ca7-4d5b-8bde-c339a6408d27"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("8e524de0-81a6-4b48-850a-1488289db21b"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("ab0fd326-01f1-4419-9eb3-f8bc8772f34d"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("b14fe439-9de4-42af-a7dc-1802f5092b0f"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("d38c51c1-80e2-4c61-b648-70ac6c7810a9"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("e1baa4e4-422c-4511-87c4-a0ce4c54da2e"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 21, 33, 22, 57, DateTimeKind.Local).AddTicks(7333), "AQAAAAIAAYagAAAAELLyGguUzB59A8+slGaYaZo0JpCEpCV4rkheDinPkHOFqAwUBkHE2meHWtXXHKvOiw==" });
        }
    }
}
