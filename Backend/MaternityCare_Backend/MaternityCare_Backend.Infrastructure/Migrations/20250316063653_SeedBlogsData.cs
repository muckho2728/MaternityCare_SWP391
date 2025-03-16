using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedBlogsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FetusHealths_FetusId",
                table: "FetusHealths");

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
                value: new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 13, 36, 52, 510, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 13, 36, 52, 510, DateTimeKind.Local).AddTicks(8224));

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
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 3, 16, 13, 36, 52, 512, DateTimeKind.Local).AddTicks(7313), "AQAAAAIAAYagAAAAEFEEyxRURzxVYxRpKSEidp0QiKS7PzqOgiCJo4fPCueAUz1FNxBGFa1k8c4yhLR2wQ==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CCCD", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmationToken", "FullName", "IsActive", "IsEmailConfirmed", "Password", "PasswordResetToken", "PasswordResetTokenExpiryTime", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "UpdatedAt", "Username" },
                values: new object[] { new Guid("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "082202000012", new DateTime(2025, 3, 16, 13, 36, 52, 568, DateTimeKind.Local).AddTicks(5913), new DateOnly(2002, 1, 23), "tannghiepnguyen123@gmail.com", null, "Nguyen Le Tan Nghiep", true, true, "AQAAAAIAAYagAAAAELeIbNYMWToYoibF0r6q0qjtLe84qPkpEVuQS1QzlAovM+HSHhyw7QI0ojmOJKL9Qg==", null, null, null, null, new Guid("416b6528-8c94-4ddc-8413-012b8ee38ae4"), null, "tannghiep" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsActive", "TagId", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("525be099-6b93-4889-9384-e986fcd8595a"), "I’m 26 weeks exactly tomorrow but I started lactating probably 3 weeks ago. It was small spots at first but now I wake up with both nipples soaked through my shirts. My obgyn says not to worry but I would like to understand why so much so early. Any ideas?", new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(276), null, true, new Guid("d1a17f1e-eb54-43bc-bdac-ca1873c99362"), "26 week already lactating", null, new Guid("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16") },
                    { new Guid("8081a98b-ec3a-4bd2-965d-063617722541"), "My peak was on February 18th, and I ovulated on the 19th. My period was supposed to start on the 1st of this month. Today is March 4th, and I still haven’t gotten my period. However, I have brownish spotting when I pee and wipe, but not every time. I took a pregnancy test this morning, and it came back negative. My BBT has been at 98°F since the 28th. I had white discharge on the 2nd and 3rd. I started the brownish spotting on the morning of 12 DPO.\"", new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(297), null, true, new Guid("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd"), "Could be implantation bleeding? anyone have a similar cycle?", null, new Guid("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16") },
                    { new Guid("d53abcd4-5ad4-42cd-b5ac-c00bdbd5191c"), "I reached my peak of ovulation on the 8th and BD twice a day alllll month. The day after I’ve had hard super tender nips. (Which I know is usual after ovulation) ever since than my breast have my sore and my nips hurt just as bad. I don’t start my period till the 23rd and I usually pms 5 days prior. Is it possible it’s a symptom? \r\n-ive been taking vitamins and eating as healthy as possible while avoiding caffeine as well", new DateTime(2025, 3, 16, 13, 36, 52, 509, DateTimeKind.Local).AddTicks(294), null, true, new Guid("7c8d65a1-ae9a-4717-8ef0-012a1f0384dd"), "Could it be a sign of early pregnancy or pms?", null, new Guid("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FetusHealths_FetusId_Week",
                table: "FetusHealths",
                columns: new[] { "FetusId", "Week" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FetusHealths_FetusId_Week",
                table: "FetusHealths");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("525be099-6b93-4889-9384-e986fcd8595a"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("8081a98b-ec3a-4bd2-965d-063617722541"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("d53abcd4-5ad4-42cd-b5ac-c00bdbd5191c"));

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12c1b9d8-dd0d-4edf-8aec-dbcf8d0aca16"));

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

            migrationBuilder.CreateIndex(
                name: "IX_FetusHealths_FetusId",
                table: "FetusHealths",
                column: "FetusId");
        }
    }
}
