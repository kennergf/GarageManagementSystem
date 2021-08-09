using Microsoft.EntityFrameworkCore.Migrations;

namespace GarageManagementSystem.Migrations
{
    public partial class CreatedSeedMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ef38b05c-8be4-4162-a344-1eec9d231943", "2d137420-c535-4fb7-9f32-801e44f4c7d4", "Mechanic", "MECHANIC" },
                    { "e3d4f4a2-1c98-486d-bc8d-1773e3766bb4", "7d36eb1e-f28b-4984-b8f8-ccd44b6f11c9", "Administrator", "ADMINISTRATOR" },
                    { "b09f1e6f-0574-4589-9c08-44d22a208054", "aaeb9d55-3071-40d0-8d46-8c1b121751fb", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "98857515-b584-464e-850c-5047904de7f7", 0, "c1df1f89-fb07-4fe9-893d-88f391acf375", "mechanic4@gms.ie", false, true, null, "Mechanic4", "MECHANIC4@GMS.IE", "MECHANIC4@GMS.IE", "AQAAAAEAACcQAAAAEMF1QmgT10yAvj7qsGmCYLcbKxF2dZJ22lDfXJw6B+2sHxiMaCAs/h2wwBiIQrfQhQ==", "0834564571", false, "ec43dd90-e97d-43fb-8958-0cccbd0bf671", false, "mechanic4@gms.ie" },
                    { "d42eb8c8-2232-406b-9bc0-3859863f064c", 0, "bd4a7385-d8ac-4722-85e1-438d78aff2e6", "admin@gms.ie", false, true, null, "Admin", "ADMIN@GMS.IE", "ADMIN@GMS.IE", "AQAAAAEAACcQAAAAEB7JkTnUZW6OABEIQUCA/W8+do2OAdsXhX6xW9pC+S5nprHmBk7gWzMJGtMm4WjgcQ==", "014569145", false, "f0f1e22d-4a2c-42f2-802b-0fe4920abb23", false, "admin@gms.ie" },
                    { "cab9f1df-6d5c-40ae-b05a-be0d0d379f55", 0, "0402f153-ff54-4553-a17d-3298feed7716", "mechanic2@gms.ie", false, true, null, "Mechanic2", "MECHANIC2@GMS.IE", "MECHANIC2@GMS.IE", "AQAAAAEAACcQAAAAENxf3reOre2p8GDYnzoWK7WEsSzoJEJD1FNPZxo7o1VGwkye0WA6TnfjmWxubiYgHg==", "0834564536", false, "60ba06cd-55e2-423d-bfc3-6a897b26d13d", false, "mechanic2@gms.ie" },
                    { "160453a8-8e19-4f70-9b61-3f6f37d82a3a", 0, "34ca02ef-8976-4a97-9759-8de3bab153b0", "mechanic1@gms.ie", false, true, null, "Mechanic1", "MECHANIC1@GMS.IE", "MECHANIC1@GMS.IE", "AQAAAAEAACcQAAAAEIAVYCJOTG1ENkOohgCmpkujWLhbjValu+q7BpYnZd+iIVVYU2sdqFoAbQjT4NB0VA==", "0834564578", false, "2e0096b1-fa6d-481e-9628-f5e895d6381a", false, "mechanic1@gms.ie" },
                    { "990d5d6b-e4b1-4978-accc-5065754d1632", 0, "6366d715-1ae3-4933-ac1a-f3413295e1f7", "mechanic3@gms.ie", false, true, null, "Mechanic3", "MECHANIC3@GMS.IE", "MECHANIC3@GMS.IE", "AQAAAAEAACcQAAAAELJqkcG7s9doqfzuKhFk63xWibqK61CYG3jjeSGi6nbGmCaDvc5vP/fWHGdzTGg9kA==", "0834564597", false, "6f6c0336-650c-4f16-a703-04fa680b2fad", false, "mechanic3@gms.ie" }
                });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "Id", "Deleted", "Name", "Value" },
                values: new object[,]
                {
                    { "f7c03548-7bf2-4c98-ba24-a839bbbeb7cf", false, "Engine computer and management system", 10.95m },
                    { "63223b7a-74b9-4f69-a9fc-031a82547cc3", false, "Anti-lock braking system (ABS) ", 150.45m },
                    { "36daa0af-e00b-4a42-813c-aac98d607219", false, "Brake disc", 10.0m },
                    { "64521dd2-8817-4c5f-b20b-7ab8130faae9", false, "Brake Fluid", 8.45m },
                    { "6a8ed31e-ee9f-4e81-8370-89d670697de1", false, "Brake pedal", 30.95m },
                    { "63e0e9bb-717b-4e49-918e-f7eaf5e7c75a", false, "Brake warning light", 3.5m },
                    { "eae82f89-3a8c-429a-9ba4-42f81a666ab4", false, "Park brake", 36.45m },
                    { "65e5ff07-6d67-4cb9-b87d-b7f1017652b3", false, "Tyre", 59.99m },
                    { "9f4d5572-4fe8-4bd0-b086-0a4df026bdcd", false, "Brake pump", 24.89m },
                    { "2eea4671-d991-49a4-ae66-13d396eb78fd", false, "Diesel engine", 1647.8m },
                    { "027fa5e1-68a2-43d7-a445-12da317c7e9d", false, "Cylinder head", 85.4m },
                    { "5adc96fe-4568-414b-8c98-83924ea78eb9", false, "Piston", 35.4m },
                    { "67c80d6e-141c-4ee7-b36e-3e27aa7dd9fb", false, "Starter motor", 28.6m },
                    { "2e76f63e-8786-4034-9c16-e98ce903aa98", false, "Petrol engine (gasoline engine)", 789.5m },
                    { "52c88e02-484c-4dec-8cbb-03f3a3c8ab56", false, "Radiator", 55.1m },
                    { "04b5a1ab-db00-4bbe-ad9c-04e2cc661191", false, "Cooling fan", 29.9m },
                    { "c3281d4e-7cce-408d-9a0d-118b369188b4", false, "Water tank", 35.4m },
                    { "be253e6b-9d63-46b3-8f4f-8bffe3be7dc0", false, "Oil filter", 15.00m },
                    { "2dff259a-feb5-4f55-a6d5-c040ba023ab2", false, "Air filter", 11.45m },
                    { "4af3bd25-a754-4368-a1da-d4bf5a32fe04", false, "Fuel filter", 17.5m },
                    { "e95bef12-794c-4c22-914e-459f0f33a77b", false, "Speed controller", 10.95m },
                    { "d199de08-7b08-432b-84f4-1d85718dc7ed", false, "Alternator", 120.0m },
                    { "4cfae684-c4a5-4766-841b-4643819395f6", false, "Transmission computer", 10.95m },
                    { "760f8dde-a5d6-45cb-a123-387a39b85163", false, "Fuse", 1.2m },
                    { "d59fbffa-8b49-48f1-bee4-6e8968cf9810", false, "Battery", 50.5m },
                    { "d803a9f6-c469-4a0a-b36d-e60e25464e00", false, "Battery Cable", 20.2m },
                    { "4afc996e-4ab7-4b2d-b8c2-4178b1c04539", false, "Voltage regulator", 3.1m },
                    { "b5fda5a3-c4fc-4da5-9102-225e57cab14f", false, "Distilled Water", 5.4m },
                    { "517c357e-59c7-44c7-ae99-d2ead2b08768", false, "Sparking cable", 10.95m },
                    { "e2500bb3-1543-4f84-941b-4a24cb5fa07b", false, "Ignition Coil", 8.45m },
                    { "dbcff1e4-2c9f-4885-98a7-c10e1020ad80", false, "Ignition box", 130.5m },
                    { "dadb742b-a3cc-40d8-b96e-42797aa7c60d", false, "Distributor", 10.95m },
                    { "4eeb90c6-b518-4757-b9c9-c9d7c4e4aa36", false, "GPS", 10.95m },
                    { "7e7c357a-e31c-45dd-9310-8a89ffd10164", false, "Headlight", 24.7m }
                });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "Id", "Deleted", "Name", "Value" },
                values: new object[,]
                {
                    { "4d82a050-aa8b-4c52-a42a-b3c180fbe046", false, "Spotlight", 9.95m },
                    { "cfa5c005-174b-47a3-aa25-0b3ce054fdd7", false, "Fog light", 4.95m },
                    { "e2086eb8-1db9-4539-92e0-73ce1b128960", false, "Brake light", 5.85m },
                    { "db8f0317-c21d-4d12-8855-796945e4a315", false, "Interior light", 8.0m },
                    { "f51474f5-0623-4e17-8470-bea39cde0383", false, "Fuel level sensor", 25.55m },
                    { "c951c665-e6ad-45a5-b114-1b1213f9d8ae", false, "Airbag sensors", 20.15m },
                    { "d50f953e-0348-4f9c-adf9-5e5b9cfecb51", false, "Oil level sensor", 15.0m },
                    { "face813d-a3d1-4e08-b06a-1327e3925b68", false, "Oil pressure sensor", 30.99m },
                    { "d8a3c5a1-c55d-413c-92ea-4d98a60269a7", false, "Coolant temperature sensor", 20.65m },
                    { "dc7ca7a1-39b5-416e-b0f2-c9b3e7097163", false, "Air bag control module", 56.79m },
                    { "7ed1a73b-89ac-487c-8768-12b9fe3bac87", false, "Alarm and siren", 25.45m },
                    { "2ecb4682-0e0e-4749-ab93-c293149a829e", false, "Central locking system", 40.9m },
                    { "23e20b65-250f-4c0e-bdfc-cbc35e4fa747", false, "Turn signal", 4.75m },
                    { "43df42f1-23c6-4c94-8da4-bb88d1427638", false, "Fuse Box", 11.55m }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Deleted", "Name", "Value" },
                values: new object[,]
                {
                    { "b29cf05f-6240-435b-bdfb-36274c9d5313", false, "Annual Service", 120.0m },
                    { "0f4ba19f-4d9e-4bf9-b1c6-8502e03e12c8", false, "Major Service", 120.0m },
                    { "cae07386-9e7b-4e02-8d37-254d110f6ca8", false, "Repair / Fault", 120.0m },
                    { "d47ebc86-da03-41b1-ad09-9d2c6bdf582e", false, "Major Repair", 120.0m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e3d4f4a2-1c98-486d-bc8d-1773e3766bb4", "d42eb8c8-2232-406b-9bc0-3859863f064c" },
                    { "ef38b05c-8be4-4162-a344-1eec9d231943", "160453a8-8e19-4f70-9b61-3f6f37d82a3a" },
                    { "ef38b05c-8be4-4162-a344-1eec9d231943", "cab9f1df-6d5c-40ae-b05a-be0d0d379f55" },
                    { "ef38b05c-8be4-4162-a344-1eec9d231943", "990d5d6b-e4b1-4978-accc-5065754d1632" },
                    { "ef38b05c-8be4-4162-a344-1eec9d231943", "98857515-b584-464e-850c-5047904de7f7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b09f1e6f-0574-4589-9c08-44d22a208054");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef38b05c-8be4-4162-a344-1eec9d231943", "160453a8-8e19-4f70-9b61-3f6f37d82a3a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef38b05c-8be4-4162-a344-1eec9d231943", "98857515-b584-464e-850c-5047904de7f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef38b05c-8be4-4162-a344-1eec9d231943", "990d5d6b-e4b1-4978-accc-5065754d1632" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef38b05c-8be4-4162-a344-1eec9d231943", "cab9f1df-6d5c-40ae-b05a-be0d0d379f55" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e3d4f4a2-1c98-486d-bc8d-1773e3766bb4", "d42eb8c8-2232-406b-9bc0-3859863f064c" });

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "027fa5e1-68a2-43d7-a445-12da317c7e9d");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "04b5a1ab-db00-4bbe-ad9c-04e2cc661191");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "23e20b65-250f-4c0e-bdfc-cbc35e4fa747");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "2dff259a-feb5-4f55-a6d5-c040ba023ab2");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "2e76f63e-8786-4034-9c16-e98ce903aa98");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "2ecb4682-0e0e-4749-ab93-c293149a829e");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "2eea4671-d991-49a4-ae66-13d396eb78fd");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "36daa0af-e00b-4a42-813c-aac98d607219");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "43df42f1-23c6-4c94-8da4-bb88d1427638");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4af3bd25-a754-4368-a1da-d4bf5a32fe04");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4afc996e-4ab7-4b2d-b8c2-4178b1c04539");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4cfae684-c4a5-4766-841b-4643819395f6");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4d82a050-aa8b-4c52-a42a-b3c180fbe046");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4eeb90c6-b518-4757-b9c9-c9d7c4e4aa36");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "517c357e-59c7-44c7-ae99-d2ead2b08768");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "52c88e02-484c-4dec-8cbb-03f3a3c8ab56");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "5adc96fe-4568-414b-8c98-83924ea78eb9");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "63223b7a-74b9-4f69-a9fc-031a82547cc3");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "63e0e9bb-717b-4e49-918e-f7eaf5e7c75a");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "64521dd2-8817-4c5f-b20b-7ab8130faae9");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "65e5ff07-6d67-4cb9-b87d-b7f1017652b3");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "67c80d6e-141c-4ee7-b36e-3e27aa7dd9fb");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "6a8ed31e-ee9f-4e81-8370-89d670697de1");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "760f8dde-a5d6-45cb-a123-387a39b85163");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "7e7c357a-e31c-45dd-9310-8a89ffd10164");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "7ed1a73b-89ac-487c-8768-12b9fe3bac87");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "9f4d5572-4fe8-4bd0-b086-0a4df026bdcd");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b5fda5a3-c4fc-4da5-9102-225e57cab14f");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "be253e6b-9d63-46b3-8f4f-8bffe3be7dc0");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "c3281d4e-7cce-408d-9a0d-118b369188b4");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "c951c665-e6ad-45a5-b114-1b1213f9d8ae");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "cfa5c005-174b-47a3-aa25-0b3ce054fdd7");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "d199de08-7b08-432b-84f4-1d85718dc7ed");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "d50f953e-0348-4f9c-adf9-5e5b9cfecb51");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "d59fbffa-8b49-48f1-bee4-6e8968cf9810");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "d803a9f6-c469-4a0a-b36d-e60e25464e00");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "d8a3c5a1-c55d-413c-92ea-4d98a60269a7");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "dadb742b-a3cc-40d8-b96e-42797aa7c60d");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "db8f0317-c21d-4d12-8855-796945e4a315");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "dbcff1e4-2c9f-4885-98a7-c10e1020ad80");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "dc7ca7a1-39b5-416e-b0f2-c9b3e7097163");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "e2086eb8-1db9-4539-92e0-73ce1b128960");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "e2500bb3-1543-4f84-941b-4a24cb5fa07b");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "e95bef12-794c-4c22-914e-459f0f33a77b");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "eae82f89-3a8c-429a-9ba4-42f81a666ab4");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "f51474f5-0623-4e17-8470-bea39cde0383");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "f7c03548-7bf2-4c98-ba24-a839bbbeb7cf");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "face813d-a3d1-4e08-b06a-1327e3925b68");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "0f4ba19f-4d9e-4bf9-b1c6-8502e03e12c8");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "b29cf05f-6240-435b-bdfb-36274c9d5313");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "cae07386-9e7b-4e02-8d37-254d110f6ca8");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "d47ebc86-da03-41b1-ad09-9d2c6bdf582e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3d4f4a2-1c98-486d-bc8d-1773e3766bb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef38b05c-8be4-4162-a344-1eec9d231943");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160453a8-8e19-4f70-9b61-3f6f37d82a3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98857515-b584-464e-850c-5047904de7f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "990d5d6b-e4b1-4978-accc-5065754d1632");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab9f1df-6d5c-40ae-b05a-be0d0d379f55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42eb8c8-2232-406b-9bc0-3859863f064c");
        }
    }
}
