using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaternityCare_Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntityInStandardFetusHealth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("19dbf6e8-314e-43aa-9437-63983f3eaaa3"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("4d993f6b-c245-43d8-a50f-6014f4cc033e"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("4e4a6f65-d4dc-4de3-8a1b-ff15dfe033cb"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("57512c5b-c834-4372-a5e5-175df37448a9"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("64b0a5ce-1eb1-4beb-9636-c861e3b7339e"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("79762f11-9e00-445d-a0af-7a75a2cb4216"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("d0557a11-3716-4d9e-aee4-e93f7237d57c"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("d5a1bd63-2248-483b-ba9a-c881b9475cbf"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("f2433255-014f-4616-aeba-475b968f81fc"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("05d6aea8-6898-4cda-9545-b3848d601566"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("08883438-39c6-4721-9778-cf06fa086795"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("08f9cb59-a27c-4df5-bcc2-8fa33d6deb95"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("09428344-3de3-4828-951b-26389e20357d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("10567af9-704a-40c8-b088-a8fa875ac127"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("182631e6-7853-4622-93eb-b5714495585a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("184ecdc3-4e9d-4129-a8b6-32c4596d6815"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1af38327-b99b-4aca-b019-ee7d46032145"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1d41aed2-276c-4d9e-8f6e-fecbbdd316d6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("225b73ae-4e2c-459a-bf92-7bf8822a0fae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("29533c71-d065-4406-bb8f-ad544f5f40f1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2b8f76b0-98ae-487a-9200-5a95e90898f7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2e739a77-5c51-456f-8779-a63f63e85080"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("31aa1901-9498-4b0b-884d-da8b50c7d693"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3b399e00-b7f8-4eaf-b6b9-3681d1731dcc"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3c4bc1b1-cf41-4917-bfad-13ae7d4a0fae"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3d9dbc29-9db7-42f8-b1c0-17fbe6805d29"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3f25f304-a0e3-4120-81cd-cd6df6015595"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4819e460-8207-4485-9321-ae9c531cb93a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4e14281a-92e3-4ff7-81b6-3d63de6edf2f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4e371d4b-c24c-4ce4-8f04-31a597a1792a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4f208928-edac-45c4-ad58-3e7f4091f485"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("50175865-7386-4a8a-9977-b5f819226423"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("55c54e2e-9abe-4d3d-8e59-b2cc9a5eff33"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("57848cfe-d142-4d45-84c2-f5887634fa27"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("58489679-4e3d-4c16-aab0-2404890fed6b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5849f99a-1406-49aa-9768-4797e808c70d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("585e3e0f-e5af-40f1-a8d1-7265a4b78ff9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6042cee0-d2b3-44c9-bdef-477adcbbc687"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("62ff8e34-cc71-473c-b0f3-0d9ac82d8821"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("63a04f7d-7a45-45ea-b6fb-fb4baeab33dc"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6911bd65-4ffd-4217-a00d-8d7e26222bcf"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("6b44a187-977d-45c0-b6ac-80a3db63e351"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("78455f60-7cbd-4568-89be-66ee5682995a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7efd41b7-ef54-477e-b656-73902d45ec43"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7ffa0b70-7b8d-4468-95e7-67c82263d93d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("80ef66a6-7cb0-4622-ad43-23f2db84a3fa"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8b93c690-d85e-4bf4-8ef1-c054549dd7ac"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8c8a13fd-4b5f-42af-8856-bbc542f0ba4f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("909cf4ce-8040-47e9-aa1f-d656a3d3e7a8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("932393b6-e6ed-4439-b78d-fa2d3a0d147c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("969acb5a-915d-4596-b2bc-5c73677bab94"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9adb9fbf-a286-45dc-96c8-cd8ef5bfe70c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9d0d5a8c-6675-4a6c-b70c-b5b15242e86b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("9ee559fa-28a1-466d-a9db-188487375cf9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a7a737dd-f990-429c-9664-8fb150de600e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("aa67da00-04a4-4162-8a77-a2cb1dd87d96"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("aa72c888-4e7c-4e5e-8fd2-6e6b360f0311"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("afef9014-3205-4bc4-9908-581a5e2df9e1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b5944087-2877-4fd4-a8b7-722ff10fbaed"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b8166a44-e397-4c26-8211-81cec5f60588"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("baf444ea-57f5-4c78-bf65-22c8eefa7605"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c3c6c1de-8ac2-4928-bcc3-67d2bbb11678"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c44598e6-9ff4-49fd-8b0d-668fb39bb979"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cb51d20d-6a6f-40aa-886b-3fff2fce5e6d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ccb4ae19-318e-4320-be7d-6fdc216aa10b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cfdc39f8-2c98-46b6-b2c2-d98f9cf3b78b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d43d2dd7-d3db-493c-a1d9-7cee8db66f08"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("da3122fa-6804-4acf-b6ac-bccf60010f77"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("da722ed9-154b-4090-8457-98bcaf4b2d63"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dd4b7081-e252-43b8-8b53-329e419ac997"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e5373175-681f-40f5-8de8-c3ac40d3b563"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e651bed9-9a16-47b1-a8c1-50981fe42074"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e8619708-910e-4ddb-90fd-6e963a3fb594"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("0c3bb823-e709-4f6d-85a3-ac8f359ba96c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("2049665f-6f5a-49e5-a3b8-29e804c0b691"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("37d279b6-ebb4-40e7-a7c2-c498dca19ff6"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("39fa548e-6309-404c-a58b-86f43a477fde"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("423c7b5a-6b57-44fc-9fd4-44d4c4c3de7c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("4823aa48-66fc-48e8-9349-29d7e0df1b45"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("553f421d-e773-4468-a1be-6f313a988536"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("70bbae7e-8e04-4cda-8ef8-8faeeb2e7336"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("740ff222-a6aa-4766-9e2d-7d99c42fc7ab"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("908557b0-79f0-4589-b777-22ac1a8d2287"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("abcd440a-b53f-40dd-adf1-dfb19ab90334"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("bdfcab46-ca59-4d76-8458-54c5d91470ff"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c4cb6782-0604-40f3-acd2-f549c84d5d59"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("cb1223f7-a6ea-467b-a169-c36de4c07ef0"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("cf227df1-6b8d-4d0e-9a3f-9ccbf2c16c67"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("dbae4eee-6d83-4187-a745-2ddac8a6a04f"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("e0a77452-c144-4934-b19b-401b52b3c6e7"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f2bc1cda-aa5b-4eab-8989-87322e8f4e54"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f3e77cfc-ac6d-432f-b91a-ce99b48fb0a9"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("f4210f50-591f-413e-83d6-b30d7e08c573"));

            migrationBuilder.AlterColumn<string>(
                name: "HeadCircumference",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GestationalSacDiameter",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FemurLength",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstimatedFetalWeight",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CrownRumpLength",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BiparietalDiameter",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AmnioticFluidLevel",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AbdominalCircumference",
                table: "StandardFetusHealths",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 21, 5, 4, 670, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 21, 5, 4, 670, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 21, 5, 4, 670, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 21, 5, 4, 670, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 21, 5, 4, 671, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 5, 21, 5, 4, 671, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("2a58c6f2-90be-4d23-99a9-0e712b046979"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("3eaead99-6fb1-4728-9821-c4a85ebfd059"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("4caede6c-8c20-4a41-8093-02b6ced54041"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 },
                    { new Guid("506a6d00-123c-429b-97be-aac9da6810de"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("509d0125-b5f3-49c1-a2a5-f08f8941b889"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("72a01e4b-641c-40a5-b20e-23585610dc61"), "You should have an anomaly scan to examine fetal anatomy.", 18 },
                    { new Guid("d97d03ae-a8c6-40e9-803b-8a71f9510dc8"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 },
                    { new Guid("ee9acd27-6a5e-4bac-8716-d1f86a9847d9"), "You’re now considered early term. You should have regular monitoring.", 37 },
                    { new Guid("f5ebe88e-f593-4b4a-b76d-3f7403855bd4"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("040805f4-dda1-40f7-ab19-6122cf02f87d"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("055f23cb-edae-4fbb-a202-86805a9f7777"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("0813b45b-fe7e-4b52-96ff-c2f8b28ddf27"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("08364f05-395d-483d-900e-7d8513f363bc"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("0a844ca6-dba3-4904-bd77-27cc55da137d"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("0eda4425-c381-4c23-85d5-83d3977df85d"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("11bf4e17-ab60-4114-afbc-7f4aa705a0f1"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("11e224a9-1757-438d-819a-cac387cab26e"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("121eda26-c63f-4866-a98b-c6f1167eb345"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("17c3807e-5d4e-4016-ae1c-0d8212b8b4bd"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("1eadf600-57f9-4b9d-807b-29ce3e79c246"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("1f047f65-0ba0-4c18-8532-8b96deb67dd4"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("22a033a9-2325-46b8-998e-26d88e9dd2a1"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("24f4d787-d6bd-4551-89cc-dd77666b16f7"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("2dd4112f-0efa-4611-83b1-40b50a3e4be7"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("311f0492-f126-48d9-912d-f9446d6b053d"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("354d65b4-a70a-43a8-8cbb-3b8de0d04510"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("3f8a4ff4-36db-4a43-86c7-535fd102258c"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("41e23096-f330-4e40-98d6-3597d8faffdf"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("42d3dc95-3ab6-419a-ad12-40dc7101d7ac"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("444137f6-e1de-4f89-ab1d-fd3c287f0f52"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("4938d89a-982b-4a62-b7bb-133d7a65f16b"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("4c505bb0-e477-4017-b447-951fc0da3e44"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("4e832071-8a48-4df2-bc9e-b841641cd210"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("5c98b514-9b14-4e7e-93cd-886ec6d38525"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("657227b9-f964-45aa-a6e4-4ef02f2f1bce"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("68d78c31-27bc-49d0-be0f-22f7e927ef63"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("729a2e3d-46c9-4a9d-b639-a1fcfdfc8454"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("7897662c-721c-4e03-a427-7f8693e24068"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("798b3bba-496d-41a3-a5a0-37786ff49302"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("8517161e-0633-4d22-98ee-baa3faa32dfd"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("855f5f62-f7e5-4b2f-bb71-7e2886be6432"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("87d925cd-0548-492b-96f5-3fc4521bf9f6"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("8dcbaf51-c474-4c41-98c0-0c6a4ea5f9a5"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("8fcfd6de-3dd7-4cb2-8a48-60c4e9ec6636"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("8fd36db6-1c3e-4be5-ae7a-169a3bd57053"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("929f5837-93f2-4cca-a970-3d8ead01a63a"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("a9bb4604-9c30-4b0b-bedb-c52bf0132b45"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("a9f6872b-057e-4f42-bbf5-097f13d7e781"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("abb30e88-74da-4b95-830d-a32f7b19ff10"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("af0e8b85-6db5-45a8-9f06-aa8414c959cf"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("b1ca1ef4-6f2a-4357-906c-fa229e3f2a36"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b4d91c35-a82b-4833-a8af-382de473fb71"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b5e6fa89-592e-44ba-8b56-910a06ca5e08"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("b876effd-9a45-4b0e-95a9-b1951c46250b"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("ba77d2dd-0a30-4b4e-8da5-3c37d8b6b000"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("be007a7c-d5ee-4fa5-b3be-5240c88c2963"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c4fc53fb-63bb-41e0-aff6-986b3fff7ac9"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c592bb92-da33-439f-b9c6-9907e646c9c0"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("c9513ca8-fccc-4503-9092-bd6202f0a34c"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("cbf6be2e-a82f-418d-8a88-ccac5e7bb7fb"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("cfdce118-3ab4-46ee-ba1c-c157f2b911f1"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("d1c7bfda-3dac-4a26-9bad-0c2bc76547f9"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("d419fbcf-c2f0-4906-b515-5fe3c3fb53ee"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("d8400615-75ff-41a3-892e-6b57394eeea4"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("dcaddbbf-37f5-4158-8fec-637ea68f3ff9"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("dd12f379-2621-400d-8f11-e613ae3a346b"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e3edf61d-ebf1-4a6a-85fb-32babd2a79c7"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e8c109ee-3825-4e20-b289-5941a83a9b13"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e984a427-e8b9-41c5-a498-ac32f852852d"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("eb93a34c-7d60-4164-a49f-7a91874329df"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("ebceed8b-fa94-4b3d-9629-a83738449f6b"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("ed651330-7ba2-4523-aaa5-8d258ac98585"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("f088e4b5-9304-492e-81ba-d2db6345c17d"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("0cb8321c-7129-464a-99dd-fe3afe6801bf"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("125155e3-e465-4ef5-9425-dba024ce020a"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("31c2ced6-ccf6-44ae-9b1d-80bf556c5e03"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("47768242-f008-474d-acd0-b424b718cbe0"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("4cebbc1e-b183-44a9-a9b8-5ad5dbba429c"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("4dca96df-1229-4636-891b-2f8cf2bcabf5"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("68dfad16-e630-4cb6-9973-7e7d12d7a4f5"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("72674a05-8076-496e-bb9d-1c05161b5c5a"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("763db8a1-4e5f-42d7-9485-0e3cd5b97de9"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("81af6bdc-5c27-426e-aee9-e899aaf87dfe"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("82a6a318-2e82-470f-b65c-bd4884b915a8"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("8f948eb1-d778-4939-9990-4c0b079111c5"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("acf28231-f9cc-44dc-b75c-68bb075a3e05"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("c6c8d977-3337-4c3c-a1a8-dbbf86665870"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("d4f0e043-d33f-4106-8dea-da32b49b1bdc"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("d575f93c-2e3b-404c-8d65-f6f7b6badf7d"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("d830d437-264e-4e8d-999e-595b7ed0a987"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("dfaf736d-385e-4ca2-af2d-6a205832e946"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("fb275bc8-95d8-48dc-b8c1-d4feb497c9bf"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("fe00cb84-c4be-4f78-b84e-39d60dd643cd"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 5, 21, 5, 4, 673, DateTimeKind.Local).AddTicks(9163), "AQAAAAIAAYagAAAAEJUsOkBCEyBLNuLzGELlFMSXqQ56uwXWd9ihtFOcC6skDW0veauuhHHCTHLzUdG/Yg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("2a58c6f2-90be-4d23-99a9-0e712b046979"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("3eaead99-6fb1-4728-9821-c4a85ebfd059"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("4caede6c-8c20-4a41-8093-02b6ced54041"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("506a6d00-123c-429b-97be-aac9da6810de"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("509d0125-b5f3-49c1-a2a5-f08f8941b889"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("72a01e4b-641c-40a5-b20e-23585610dc61"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("d97d03ae-a8c6-40e9-803b-8a71f9510dc8"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("ee9acd27-6a5e-4bac-8716-d1f86a9847d9"));

            migrationBuilder.DeleteData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: new Guid("f5ebe88e-f593-4b4a-b76d-3f7403855bd4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("040805f4-dda1-40f7-ab19-6122cf02f87d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("055f23cb-edae-4fbb-a202-86805a9f7777"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0813b45b-fe7e-4b52-96ff-c2f8b28ddf27"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("08364f05-395d-483d-900e-7d8513f363bc"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0a844ca6-dba3-4904-bd77-27cc55da137d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0eda4425-c381-4c23-85d5-83d3977df85d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("11bf4e17-ab60-4114-afbc-7f4aa705a0f1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("11e224a9-1757-438d-819a-cac387cab26e"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("121eda26-c63f-4866-a98b-c6f1167eb345"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("17c3807e-5d4e-4016-ae1c-0d8212b8b4bd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1eadf600-57f9-4b9d-807b-29ce3e79c246"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("1f047f65-0ba0-4c18-8532-8b96deb67dd4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("22a033a9-2325-46b8-998e-26d88e9dd2a1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("24f4d787-d6bd-4551-89cc-dd77666b16f7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("2dd4112f-0efa-4611-83b1-40b50a3e4be7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("311f0492-f126-48d9-912d-f9446d6b053d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("354d65b4-a70a-43a8-8cbb-3b8de0d04510"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("3f8a4ff4-36db-4a43-86c7-535fd102258c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("41e23096-f330-4e40-98d6-3597d8faffdf"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("42d3dc95-3ab6-419a-ad12-40dc7101d7ac"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("444137f6-e1de-4f89-ab1d-fd3c287f0f52"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4938d89a-982b-4a62-b7bb-133d7a65f16b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4c505bb0-e477-4017-b447-951fc0da3e44"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("4e832071-8a48-4df2-bc9e-b841641cd210"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("5c98b514-9b14-4e7e-93cd-886ec6d38525"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("657227b9-f964-45aa-a6e4-4ef02f2f1bce"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("68d78c31-27bc-49d0-be0f-22f7e927ef63"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("729a2e3d-46c9-4a9d-b639-a1fcfdfc8454"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("7897662c-721c-4e03-a427-7f8693e24068"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("798b3bba-496d-41a3-a5a0-37786ff49302"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8517161e-0633-4d22-98ee-baa3faa32dfd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("855f5f62-f7e5-4b2f-bb71-7e2886be6432"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("87d925cd-0548-492b-96f5-3fc4521bf9f6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8dcbaf51-c474-4c41-98c0-0c6a4ea5f9a5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8fcfd6de-3dd7-4cb2-8a48-60c4e9ec6636"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("8fd36db6-1c3e-4be5-ae7a-169a3bd57053"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("929f5837-93f2-4cca-a970-3d8ead01a63a"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a9bb4604-9c30-4b0b-bedb-c52bf0132b45"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("a9f6872b-057e-4f42-bbf5-097f13d7e781"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("abb30e88-74da-4b95-830d-a32f7b19ff10"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("af0e8b85-6db5-45a8-9f06-aa8414c959cf"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b1ca1ef4-6f2a-4357-906c-fa229e3f2a36"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b4d91c35-a82b-4833-a8af-382de473fb71"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b5e6fa89-592e-44ba-8b56-910a06ca5e08"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("b876effd-9a45-4b0e-95a9-b1951c46250b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ba77d2dd-0a30-4b4e-8da5-3c37d8b6b000"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("be007a7c-d5ee-4fa5-b3be-5240c88c2963"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c4fc53fb-63bb-41e0-aff6-986b3fff7ac9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c592bb92-da33-439f-b9c6-9907e646c9c0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("c9513ca8-fccc-4503-9092-bd6202f0a34c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cbf6be2e-a82f-418d-8a88-ccac5e7bb7fb"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("cfdce118-3ab4-46ee-ba1c-c157f2b911f1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d1c7bfda-3dac-4a26-9bad-0c2bc76547f9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d419fbcf-c2f0-4906-b515-5fe3c3fb53ee"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("d8400615-75ff-41a3-892e-6b57394eeea4"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dcaddbbf-37f5-4158-8fec-637ea68f3ff9"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("dd12f379-2621-400d-8f11-e613ae3a346b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e3edf61d-ebf1-4a6a-85fb-32babd2a79c7"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e8c109ee-3825-4e20-b289-5941a83a9b13"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("e984a427-e8b9-41c5-a498-ac32f852852d"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("eb93a34c-7d60-4164-a49f-7a91874329df"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ebceed8b-fa94-4b3d-9629-a83738449f6b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("ed651330-7ba2-4523-aaa5-8d258ac98585"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("f088e4b5-9304-492e-81ba-d2db6345c17d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("0cb8321c-7129-464a-99dd-fe3afe6801bf"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("125155e3-e465-4ef5-9425-dba024ce020a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("31c2ced6-ccf6-44ae-9b1d-80bf556c5e03"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("47768242-f008-474d-acd0-b424b718cbe0"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("4cebbc1e-b183-44a9-a9b8-5ad5dbba429c"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("4dca96df-1229-4636-891b-2f8cf2bcabf5"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("68dfad16-e630-4cb6-9973-7e7d12d7a4f5"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("72674a05-8076-496e-bb9d-1c05161b5c5a"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("763db8a1-4e5f-42d7-9485-0e3cd5b97de9"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("81af6bdc-5c27-426e-aee9-e899aaf87dfe"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("82a6a318-2e82-470f-b65c-bd4884b915a8"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("8f948eb1-d778-4939-9990-4c0b079111c5"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("acf28231-f9cc-44dc-b75c-68bb075a3e05"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("c6c8d977-3337-4c3c-a1a8-dbbf86665870"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d4f0e043-d33f-4106-8dea-da32b49b1bdc"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d575f93c-2e3b-404c-8d65-f6f7b6badf7d"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("d830d437-264e-4e8d-999e-595b7ed0a987"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("dfaf736d-385e-4ca2-af2d-6a205832e946"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("fb275bc8-95d8-48dc-b8c1-d4feb497c9bf"));

            migrationBuilder.DeleteData(
                table: "StandardFetusHealths",
                keyColumn: "Id",
                keyValue: new Guid("fe00cb84-c4be-4f78-b84e-39d60dd643cd"));

            migrationBuilder.AlterColumn<string>(
                name: "HeadCircumference",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GestationalSacDiameter",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FemurLength",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstimatedFetalWeight",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CrownRumpLength",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BiparietalDiameter",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AmnioticFluidLevel",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AbdominalCircumference",
                table: "StandardFetusHealths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 2, 1, 15, 33, 37, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 2, 1, 15, 33, 37, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 2, 1, 15, 33, 37, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 2, 1, 15, 33, 37, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("595a4777-de2b-4c8a-a45f-3ddba55dddee"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 2, 1, 15, 33, 38, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e401f557-307a-4b1d-b65b-d7c26f3aac61"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 2, 1, 15, 33, 38, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.InsertData(
                table: "Reminders",
                columns: new[] { "Id", "Description", "Week" },
                values: new object[,]
                {
                    { new Guid("19dbf6e8-314e-43aa-9437-63983f3eaaa3"), "From now on, you have schedule an appointment with your doctor once a week to make sure the baby is developing weel.", 31 },
                    { new Guid("4d993f6b-c245-43d8-a50f-6014f4cc033e"), "You’re now considered full term. You should attend all scheduled prenatal appointments and contact your provider if you experience any changes or discomfort.", 39 },
                    { new Guid("4e4a6f65-d4dc-4de3-8a1b-ff15dfe033cb"), "You should have your first-trimester screening to check for chromosomal conditions.", 9 },
                    { new Guid("57512c5b-c834-4372-a5e5-175df37448a9"), "This is the beginning of the second trimester. A routine check-up is a must to check if the pregnancy is progressing normally", 13 },
                    { new Guid("64b0a5ce-1eb1-4beb-9636-c861e3b7339e"), "This is the beginning of the third trimester. You should have schedule for additional tests or screenings (such as for anemia or gestational diabetes)", 25 },
                    { new Guid("79762f11-9e00-445d-a0af-7a75a2cb4216"), "You should have the mid-pregnancy ultrasound to check the baby’s development.", 20 },
                    { new Guid("d0557a11-3716-4d9e-aee4-e93f7237d57c"), "You’re now considered early term. You should have regular monitoring.", 37 },
                    { new Guid("d5a1bd63-2248-483b-ba9a-c881b9475cbf"), "You should have your first prenatal visit and have an ultrasound or blood tests to confirm the pregnancy.", 5 },
                    { new Guid("f2433255-014f-4616-aeba-475b968f81fc"), "You should have an anomaly scan to examine fetal anatomy.", 18 }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "IsBooked", "StartTime" },
                values: new object[,]
                {
                    { new Guid("05d6aea8-6898-4cda-9545-b3848d601566"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("08883438-39c6-4721-9778-cf06fa086795"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("08f9cb59-a27c-4df5-bcc2-8fa33d6deb95"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("09428344-3de3-4828-951b-26389e20357d"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("10567af9-704a-40c8-b088-a8fa875ac127"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("182631e6-7853-4622-93eb-b5714495585a"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("184ecdc3-4e9d-4129-a8b6-32c4596d6815"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("1af38327-b99b-4aca-b019-ee7d46032145"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("1d41aed2-276c-4d9e-8f6e-fecbbdd316d6"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("225b73ae-4e2c-459a-bf92-7bf8822a0fae"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("29533c71-d065-4406-bb8f-ad544f5f40f1"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("2b8f76b0-98ae-487a-9200-5a95e90898f7"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("2e739a77-5c51-456f-8779-a63f63e85080"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("31aa1901-9498-4b0b-884d-da8b50c7d693"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("3b399e00-b7f8-4eaf-b6b9-3681d1731dcc"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("3c4bc1b1-cf41-4917-bfad-13ae7d4a0fae"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("3d9dbc29-9db7-42f8-b1c0-17fbe6805d29"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("3f25f304-a0e3-4120-81cd-cd6df6015595"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("4819e460-8207-4485-9321-ae9c531cb93a"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("4e14281a-92e3-4ff7-81b6-3d63de6edf2f"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("4e371d4b-c24c-4ce4-8f04-31a597a1792a"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("4f208928-edac-45c4-ad58-3e7f4091f485"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("50175865-7386-4a8a-9977-b5f819226423"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("55c54e2e-9abe-4d3d-8e59-b2cc9a5eff33"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("57848cfe-d142-4d45-84c2-f5887634fa27"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("58489679-4e3d-4c16-aab0-2404890fed6b"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("5849f99a-1406-49aa-9768-4797e808c70d"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("585e3e0f-e5af-40f1-a8d1-7265a4b78ff9"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("6042cee0-d2b3-44c9-bdef-477adcbbc687"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("62ff8e34-cc71-473c-b0f3-0d9ac82d8821"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("63a04f7d-7a45-45ea-b6fb-fb4baeab33dc"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("6911bd65-4ffd-4217-a00d-8d7e26222bcf"), new DateOnly(2025, 4, 7), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("6b44a187-977d-45c0-b6ac-80a3db63e351"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("78455f60-7cbd-4568-89be-66ee5682995a"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("7efd41b7-ef54-477e-b656-73902d45ec43"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("7ffa0b70-7b8d-4468-95e7-67c82263d93d"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("80ef66a6-7cb0-4622-ad43-23f2db84a3fa"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("8b93c690-d85e-4bf4-8ef1-c054549dd7ac"), new DateOnly(2025, 4, 1), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("8c8a13fd-4b5f-42af-8856-bbc542f0ba4f"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("909cf4ce-8040-47e9-aa1f-d656a3d3e7a8"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("932393b6-e6ed-4439-b78d-fa2d3a0d147c"), new DateOnly(2025, 4, 11), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("969acb5a-915d-4596-b2bc-5c73677bab94"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("9adb9fbf-a286-45dc-96c8-cd8ef5bfe70c"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("9d0d5a8c-6675-4a6c-b70c-b5b15242e86b"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("9ee559fa-28a1-466d-a9db-188487375cf9"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("a7a737dd-f990-429c-9664-8fb150de600e"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("aa67da00-04a4-4162-8a77-a2cb1dd87d96"), new DateOnly(2025, 4, 10), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("aa72c888-4e7c-4e5e-8fd2-6e6b360f0311"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("afef9014-3205-4bc4-9908-581a5e2df9e1"), new DateOnly(2025, 4, 4), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("b5944087-2877-4fd4-a8b7-722ff10fbaed"), new DateOnly(2025, 4, 4), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("b8166a44-e397-4c26-8211-81cec5f60588"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("baf444ea-57f5-4c78-bf65-22c8eefa7605"), new DateOnly(2025, 3, 31), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("c3c6c1de-8ac2-4928-bcc3-67d2bbb11678"), new DateOnly(2025, 4, 8), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("c44598e6-9ff4-49fd-8b0d-668fb39bb979"), new DateOnly(2025, 4, 3), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("cb51d20d-6a6f-40aa-886b-3fff2fce5e6d"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("ccb4ae19-318e-4320-be7d-6fdc216aa10b"), new DateOnly(2025, 4, 11), new Guid("91d4bcac-44fe-4959-bb87-75e0865e4f8c"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("cfdc39f8-2c98-46b6-b2c2-d98f9cf3b78b"), new DateOnly(2025, 4, 1), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("d43d2dd7-d3db-493c-a1d9-7cee8db66f08"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("da3122fa-6804-4acf-b6ac-bccf60010f77"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(11, 0, 0), false, new TimeOnly(10, 30, 0) },
                    { new Guid("da722ed9-154b-4090-8457-98bcaf4b2d63"), new DateOnly(2025, 4, 7), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(14, 0, 0), false, new TimeOnly(13, 30, 0) },
                    { new Guid("dd4b7081-e252-43b8-8b53-329e419ac997"), new DateOnly(2025, 4, 3), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e5373175-681f-40f5-8de8-c3ac40d3b563"), new DateOnly(2025, 3, 31), new Guid("7983bd2f-20c4-4d9b-89bd-b5099c704286"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) },
                    { new Guid("e651bed9-9a16-47b1-a8c1-50981fe42074"), new DateOnly(2025, 4, 8), new Guid("39dce4a1-f917-4d8b-bde6-9994c1bb8a94"), new TimeOnly(10, 30, 0), false, new TimeOnly(10, 0, 0) },
                    { new Guid("e8619708-910e-4ddb-90fd-6e963a3fb594"), new DateOnly(2025, 4, 10), new Guid("1f498837-82e7-4901-b4d6-4810f4aa1785"), new TimeOnly(13, 30, 0), false, new TimeOnly(13, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "StandardFetusHealths",
                columns: new[] { "Id", "AbdominalCircumference", "AmnioticFluidLevel", "BiparietalDiameter", "CrownRumpLength", "EstimatedFetalWeight", "FemurLength", "GestationalSacDiameter", "HeadCircumference", "Week" },
                values: new object[,]
                {
                    { new Guid("0c3bb823-e709-4f6d-85a3-ac8f359ba96c"), null, "2-3", null, "4-9", null, null, "14-25", null, 6 },
                    { new Guid("2049665f-6f5a-49e5-a3b8-29e804c0b691"), "270-310", "2-8", "80-85", null, "2100-2500", "60-65", null, "290-310", 34 },
                    { new Guid("37d279b6-ebb4-40e7-a7c2-c498dca19ff6"), "110-130", "2-8", "38-45", null, "190-220", "22-27", null, "130-150", 18 },
                    { new Guid("39fa548e-6309-404c-a58b-86f43a477fde"), "190-220", "2-8", "60-65", null, "750-850", "42-47", null, "210-230", 26 },
                    { new Guid("423c7b5a-6b57-44fc-9fd4-44d4c4c3de7c"), null, "2-3", "15-22", "31-40", "5-8", "7-9", "30-40", "56-78", 10 },
                    { new Guid("4823aa48-66fc-48e8-9349-29d7e0df1b45"), "170-200", "2-8", "55-60", null, "500-600", "38-42", null, "190-210", 24 },
                    { new Guid("553f421d-e773-4468-a1be-6f313a988536"), "250-290", "2-8", "75-80", null, "1700-2000", "56-60", null, "270-290", 32 },
                    { new Guid("70bbae7e-8e04-4cda-8ef8-8faeeb2e7336"), "125-155", "2-8", "45-50", null, "260-300", "30-34", null, "150-170", 20 },
                    { new Guid("740ff222-a6aa-4766-9e2d-7d99c42fc7ab"), "310-350", "2-8", "90-95", null, "2900-3200", "70-75", null, "330-350", 38 },
                    { new Guid("908557b0-79f0-4589-b777-22ac1a8d2287"), null, "2-3", null, "9-14", null, null, "18-30", null, 7 },
                    { new Guid("abcd440a-b53f-40dd-adf1-dfb19ab90334"), null, "2-3", null, "14-22", null, null, "25-35", null, 8 },
                    { new Guid("bdfcab46-ca59-4d76-8458-54c5d91470ff"), "290-330", "2-8", "85-90", null, "2500-2900", "65-70", null, "310-330", 36 },
                    { new Guid("c4cb6782-0604-40f3-acd2-f549c84d5d59"), "70-85", "2-8", "24-30", "78-85", "40-60", "14-17", null, "90-110", 14 },
                    { new Guid("cb1223f7-a6ea-467b-a169-c36de4c07ef0"), "320-360", "2-8", "95-100", null, "3200-3500", "75-80", null, "350-370", 40 },
                    { new Guid("cf227df1-6b8d-4d0e-9a3f-9ccbf2c16c67"), null, "2-3", null, "22-31", null, null, "28-36", null, 9 },
                    { new Guid("dbae4eee-6d83-4187-a745-2ddac8a6a04f"), "150-180", "2-8", "50-55", null, "350-420", "34-38", null, "170-190", 22 },
                    { new Guid("e0a77452-c144-4934-b19b-401b52b3c6e7"), "210-250", "2-8", "65-70", null, "1000-1200", "47-52", null, "230-250", 28 },
                    { new Guid("f2bc1cda-aa5b-4eab-8989-87322e8f4e54"), "90-110", "2-8", "32-38", null, "100-150", "18-22", null, "110-130", 16 },
                    { new Guid("f3e77cfc-ac6d-432f-b91a-ce99b48fb0a9"), "50-65", "2-3", "21-24", "50-60", "14-19", "9-12", "40-50", "70-85", 12 },
                    { new Guid("f4210f50-591f-413e-83d6-b30d7e08c573"), "230-270", "2-8", "70-75", null, "1400-1600", "52-56", null, "250-270", 30 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0c434f-b4b8-4342-a991-b343f2b0ee3d"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 2, 1, 15, 33, 39, DateTimeKind.Local).AddTicks(8494), "AQAAAAIAAYagAAAAELTq8jNcUASsgkIy6YxRzS+PEEuKsjHmRlGnGY0FInCiE8ak1vIWR0BU45on21W9eg==" });
        }
    }
}
