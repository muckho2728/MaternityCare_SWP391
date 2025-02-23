using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexUserAppointmentLike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_BlogId",
                table: "Likes");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Likes_BlogId_UserId",
                table: "Likes",
                columns: new[] { "BlogId", "UserId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Likes_BlogId_UserId",
                table: "Likes");

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

            migrationBuilder.CreateIndex(
                name: "IX_Likes_BlogId",
                table: "Likes",
                column: "BlogId");
        }
    }
}
