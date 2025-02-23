using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("16e37a3e-affc-40f7-b34a-45745fe8875e"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("30511e3a-1628-47ae-bfa8-d3095963ee97"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("456f3e10-e3aa-486c-8364-34ee89ff8a3c"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("515cfda8-808e-43f2-bb9e-d3d640db1102"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("52db8010-ab95-4dba-b348-006eeac83031"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("c5e8b700-662e-4289-af0f-f05a61385542"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("ddc74737-e169-46d7-9d06-684d3f790165"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("e5118672-edd4-426f-a514-1bd7cc02d7bc"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("f35c1e59-36b6-4f10-b604-3d72c01b13cb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("015f79b3-b427-4bd9-84ed-d5f997ee6893"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("08a00526-b999-438f-897d-e4225f4189b2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0afa0287-7b05-42e5-8013-c8c4cc6ebf00"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0bad717f-3be7-49de-b991-2f78fcbf349b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0c1789b5-fe54-48ab-9f38-428dac26c6a7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("12b8a4c9-4b49-48fa-908a-63cf85f3d0ba"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("12c7da94-6bd6-433c-ab17-990ae281d657"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("135b64cb-5b93-4603-8faf-3e4d8e260b8f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1b8ac11a-a5e0-4b86-9796-b5f4794c0aae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("201a3ed8-f29a-47a1-a0c5-cc922cc11ede"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("21e1e6c2-082e-43bb-a0ba-f6a6218845aa"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("223bc431-1313-4c24-9936-94035418637f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("24b8b0b8-4215-468b-8c3c-36c9c515f8b7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("26386b71-bbad-4fe1-96e8-75f7743575fe"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2ed0a1b9-e534-49dc-ad2c-8ab9fab9ffcd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("313224dc-6e94-4556-9c12-d4313842c7a4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3308aba4-9cdc-425f-b8be-b821caf6f62c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("38b2e766-6930-4388-bd8a-5a30b873c0b2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3fc84487-5da5-4a30-a522-1c799529cb6c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("40816d3b-6063-49d6-8201-58bd6e4e837f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4179c515-40b7-47fb-b50a-e7d054aad4ab"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4229ae57-ede6-41de-984d-aa61804290aa"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("43946414-c799-49ca-95f9-5be591b88cd7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("43df7c8f-6b04-4243-8444-abda2b59956c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("46d939b0-688c-447c-b296-c4f9e5bf8c23"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("53f6e427-fa64-4732-a35c-adfecd8404e1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("55f158ba-9e28-4d68-9bec-605e4a658b55"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("576aff08-8232-441b-ad97-11df8fe34ace"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5cdf273f-65af-4dcc-a030-661c25bf0ea5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("60acc408-7dfb-4238-8ae9-aff90597d4dd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("730f6b45-2376-4e7d-bdc0-12770cb57e15"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7b12c438-c6ab-4a38-88bc-2ec1d1b14424"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7dc02093-20d8-46ba-b4d9-ddac62c2aee8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("80b939c1-c86a-4625-a518-0ea6faaff836"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("843b46ba-13fa-45d2-af65-0b0e7b784b16"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("86120cec-f917-4f98-893c-d652da4f4491"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("88529011-c0ca-4517-bc17-cb4ee2d02b80"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("89703ec0-d1b9-41bc-853c-420d247a3725"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8b19646a-9ba1-43ba-b480-23b64e1dcd10"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("963f9026-38a2-4423-bb1a-ed3aae89916e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9eb7bd85-26e5-4ed7-bd0b-7d0091646ee3"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("aa7e1171-26f4-4fb5-be5a-75d7084d0bd2"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ac475d88-e665-435a-8645-d11eae70348f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b17e8b8c-da3f-49d6-be91-09fbc7a238ae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b84cc980-c628-4a28-b91a-9fca4a6b7693"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("be4450d3-77c6-45a3-a487-35cb804176e7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c0816fb9-9417-452b-abf1-cb1c454f8d8a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c0a642ac-7d32-4f9a-b17c-e7e96d9c935e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c63554f0-d08e-49ef-b385-595f09f90d18"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c6be18e5-40da-4f23-9b97-ffcf78776336"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cf88c464-bbb6-4832-a11e-588c45b7320a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d4cc9e55-06bb-4058-8b57-96bcc34daf05"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("de878c51-4349-4140-a995-e984406b84ed"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("df0a88d2-dcfb-43ae-a48d-676649d89452"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("efd736a3-1a32-47b0-a7f8-7eb078d7bf40"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("efd90989-ed81-4641-a229-c03b9df0d0a1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f33813ae-fa97-4f6b-8c23-d95b92e94a19"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f42cba56-167f-4bba-8801-a65dce513ed7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f5ec0f97-4116-4805-85ad-1760a0a5570c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f6620079-daa8-4fcf-a0bd-5cb1868a06b6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f6a98804-7a17-477c-b6a6-8c1cf0cdb8c5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f6ff7d6e-cff9-428d-8455-1a6467970959"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fcd02866-3cd2-49a5-80bc-f9c97ec7ddb5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("fe66c66d-adee-41fc-a5cb-74344202ae2e"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("1d358d3d-c98d-4370-bd1d-bb09263953cb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("3aac46f5-d8f0-40d3-8fec-85235596328d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("475d0144-74f5-4005-9253-d82a7e27d833"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("57df4a09-e052-4eac-af2b-de44c8b5fae0"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("5cb3ed62-202b-4482-a301-59fbab7f9107"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("649c1692-ca03-4988-92c0-dc0964a64b1e"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7be82c3c-181b-495f-9e63-0eee9c17cadb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("7f756825-06ef-46e1-be0d-b3b9fb36022d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("9c05e53a-33c9-469e-9566-dce591bbabb7"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("a1420486-ca3d-4ca9-a74b-2717d5778247"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b39b7e7b-6161-4328-a6a4-06f37f41f948"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("b974c03a-2863-414c-8401-b952115c43cb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ba36d814-dc30-4f9a-88b9-9a1c2b2df74b"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("bcf3e40a-0a2c-40c7-8b62-9312bbaf500a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c2204904-ea12-4354-a4c4-dc58e866ef9a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c52b1276-8341-4e42-b6a8-e762aeff744b"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("ce0aeab6-2cd6-4f38-8fe9-52add5a68beb"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d8740bed-5e78-42aa-a10c-1c36a7f5dcc9"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f25b9da7-bdfe-4de9-8169-f81bf80f816c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f9a88432-9482-430f-9d87-266193a9546e"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2025, 2, 23, 21, 33, 0, 236, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 0, 236, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 0, 236, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 0, 236, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 0, 237, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 21, 33, 0, 237, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("16e37a3e-affc-40f7-b34a-45745fe8875e"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("30511e3a-1628-47ae-bfa8-d3095963ee97"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("456f3e10-e3aa-486c-8364-34ee89ff8a3c"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("515cfda8-808e-43f2-bb9e-d3d640db1102"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("52db8010-ab95-4dba-b348-006eeac83031"), "You should have an anomaly scan to examine fetal anatomy.", 18 },
                    { new Guid("c5e8b700-662e-4289-af0f-f05a61385542"), "You’re now considered early term. You should have regular monitoring.", 37 },
                    { new Guid("ddc74737-e169-46d7-9d06-684d3f790165"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 },
                    { new Guid("e5118672-edd4-426f-a514-1bd7cc02d7bc"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 },
                    { new Guid("f35c1e59-36b6-4f10-b604-3d72c01b13cb"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("015f79b3-b427-4bd9-84ed-d5f997ee6893"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("08a00526-b999-438f-897d-e4225f4189b2"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("0afa0287-7b05-42e5-8013-c8c4cc6ebf00"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("0bad717f-3be7-49de-b991-2f78fcbf349b"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("0c1789b5-fe54-48ab-9f38-428dac26c6a7"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("12b8a4c9-4b49-48fa-908a-63cf85f3d0ba"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("12c7da94-6bd6-433c-ab17-990ae281d657"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("135b64cb-5b93-4603-8faf-3e4d8e260b8f"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1b8ac11a-a5e0-4b86-9796-b5f4794c0aae"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("201a3ed8-f29a-47a1-a0c5-cc922cc11ede"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("21e1e6c2-082e-43bb-a0ba-f6a6218845aa"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("223bc431-1313-4c24-9936-94035418637f"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("24b8b0b8-4215-468b-8c3c-36c9c515f8b7"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("26386b71-bbad-4fe1-96e8-75f7743575fe"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("2ed0a1b9-e534-49dc-ad2c-8ab9fab9ffcd"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("313224dc-6e94-4556-9c12-d4313842c7a4"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("3308aba4-9cdc-425f-b8be-b821caf6f62c"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("38b2e766-6930-4388-bd8a-5a30b873c0b2"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("3fc84487-5da5-4a30-a522-1c799529cb6c"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("40816d3b-6063-49d6-8201-58bd6e4e837f"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("4179c515-40b7-47fb-b50a-e7d054aad4ab"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("4229ae57-ede6-41de-984d-aa61804290aa"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("43946414-c799-49ca-95f9-5be591b88cd7"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("43df7c8f-6b04-4243-8444-abda2b59956c"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("46d939b0-688c-447c-b296-c4f9e5bf8c23"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("53f6e427-fa64-4732-a35c-adfecd8404e1"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("55f158ba-9e28-4d68-9bec-605e4a658b55"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("576aff08-8232-441b-ad97-11df8fe34ace"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("5cdf273f-65af-4dcc-a030-661c25bf0ea5"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("60acc408-7dfb-4238-8ae9-aff90597d4dd"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("730f6b45-2376-4e7d-bdc0-12770cb57e15"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("7b12c438-c6ab-4a38-88bc-2ec1d1b14424"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("7dc02093-20d8-46ba-b4d9-ddac62c2aee8"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("80b939c1-c86a-4625-a518-0ea6faaff836"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("843b46ba-13fa-45d2-af65-0b0e7b784b16"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("86120cec-f917-4f98-893c-d652da4f4491"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("88529011-c0ca-4517-bc17-cb4ee2d02b80"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("89703ec0-d1b9-41bc-853c-420d247a3725"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("8b19646a-9ba1-43ba-b480-23b64e1dcd10"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("963f9026-38a2-4423-bb1a-ed3aae89916e"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("9eb7bd85-26e5-4ed7-bd0b-7d0091646ee3"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("aa7e1171-26f4-4fb5-be5a-75d7084d0bd2"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("ac475d88-e665-435a-8645-d11eae70348f"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("b17e8b8c-da3f-49d6-be91-09fbc7a238ae"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b84cc980-c628-4a28-b91a-9fca4a6b7693"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("be4450d3-77c6-45a3-a487-35cb804176e7"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c0816fb9-9417-452b-abf1-cb1c454f8d8a"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("c0a642ac-7d32-4f9a-b17c-e7e96d9c935e"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c63554f0-d08e-49ef-b385-595f09f90d18"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c6be18e5-40da-4f23-9b97-ffcf78776336"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("cf88c464-bbb6-4832-a11e-588c45b7320a"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("d4cc9e55-06bb-4058-8b57-96bcc34daf05"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("de878c51-4349-4140-a995-e984406b84ed"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("df0a88d2-dcfb-43ae-a48d-676649d89452"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("efd736a3-1a32-47b0-a7f8-7eb078d7bf40"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("efd90989-ed81-4641-a229-c03b9df0d0a1"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("f33813ae-fa97-4f6b-8c23-d95b92e94a19"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("f42cba56-167f-4bba-8801-a65dce513ed7"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f5ec0f97-4116-4805-85ad-1760a0a5570c"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f6620079-daa8-4fcf-a0bd-5cb1868a06b6"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f6a98804-7a17-477c-b6a6-8c1cf0cdb8c5"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("f6ff7d6e-cff9-428d-8455-1a6467970959"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("fcd02866-3cd2-49a5-80bc-f9c97ec7ddb5"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("fe66c66d-adee-41fc-a5cb-74344202ae2e"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("1d358d3d-c98d-4370-bd1d-bb09263953cb"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("3aac46f5-d8f0-40d3-8fec-85235596328d"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("475d0144-74f5-4005-9253-d82a7e27d833"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("57df4a09-e052-4eac-af2b-de44c8b5fae0"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("5cb3ed62-202b-4482-a301-59fbab7f9107"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("649c1692-ca03-4988-92c0-dc0964a64b1e"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("7be82c3c-181b-495f-9e63-0eee9c17cadb"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 },
                    { new Guid("7f756825-06ef-46e1-be0d-b3b9fb36022d"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("9c05e53a-33c9-469e-9566-dce591bbabb7"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("a1420486-ca3d-4ca9-a74b-2717d5778247"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("b39b7e7b-6161-4328-a6a4-06f37f41f948"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("b974c03a-2863-414c-8401-b952115c43cb"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("ba36d814-dc30-4f9a-88b9-9a1c2b2df74b"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("bcf3e40a-0a2c-40c7-8b62-9312bbaf500a"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("c2204904-ea12-4354-a4c4-dc58e866ef9a"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("c52b1276-8341-4e42-b6a8-e762aeff744b"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("ce0aeab6-2cd6-4f38-8fe9-52add5a68beb"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("d8740bed-5e78-42aa-a10c-1c36a7f5dcc9"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("f25b9da7-bdfe-4de9-8169-f81bf80f816c"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("f9a88432-9482-430f-9d87-266193a9546e"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 21, 33, 0, 239, DateTimeKind.Local).AddTicks(5135), "AQAAAAIAAYagAAAAEN/8zbAIvh8DTTLKNOIutVFDwMUZzQKmykz5xlaLHc+FnemQR7MZ7St6Hxcbi3sTuQ==" });
        }
    }
}
