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
                    { "98857515-b584-464e-850c-5047904de7f7", 0, "e5999934-7acf-403f-adde-4ee85c2ab3ac", "mechanic4@gms.ie", false, true, null, "Mechanic4", "MECHANIC4@GMS.IE", "MECHANIC4@GMS.IE", "AQAAAAEAACcQAAAAECr7dcXWjJXHb8buILO/TKpR28JQvwla1x2tXA4BG4XXccB+sG/3aiCafzks57IhtQ==", "0834564571", false, "e959c3aa-726d-49c4-b9e9-49e764539285", false, "mechanic4@gms.ie" },
                    { "d42eb8c8-2232-406b-9bc0-3859863f064c", 0, "fdc684f7-ef90-4958-965c-4e6460f238d7", "admin@gms.ie", false, true, null, "Admin", "ADMIN@GMS.IE", "ADMIN@GMS.IE", "AQAAAAEAACcQAAAAEMIIaQTSVD+P1Y8VpIvutWphRS1E1Ux1mBWr3Difwn3CSaCfpxYUrqBrcCE3esZUlg==", "014569145", false, "578df42e-b2a8-4286-8742-ad0592ab8e8a", false, "admin@gms.ie" },
                    { "cab9f1df-6d5c-40ae-b05a-be0d0d379f55", 0, "fcd13006-3fd0-4b68-8114-170f89ffe41d", "mechanic2@gms.ie", false, true, null, "Mechanic2", "MECHANIC2@GMS.IE", "MECHANIC2@GMS.IE", "AQAAAAEAACcQAAAAEDwP3gbdeZxkRJ1T2Md18PyREUsQf7NCs5TBDfnV0bz2mp5nhAh2DrBp0dnR+4PVFA==", "0834564536", false, "cd1f0ff6-e0a6-435b-918c-7fba8b29407e", false, "mechanic2@gms.ie" },
                    { "160453a8-8e19-4f70-9b61-3f6f37d82a3a", 0, "0e670975-babf-4417-9575-4f80c821a7c0", "mechanic1@gms.ie", false, true, null, "Mechanic1", "MECHANIC1@GMS.IE", "MECHANIC1@GMS.IE", "AQAAAAEAACcQAAAAEHcMjaOj2SWhgsO/Zx3RzRK+h2avq9pMIVFXNRX45d5IUc0i7H6zumWkMUMCOEOv0Q==", "0834564578", false, "ba9871ff-891a-4cca-a900-2cd579893694", false, "mechanic1@gms.ie" },
                    { "990d5d6b-e4b1-4978-accc-5065754d1632", 0, "5d0251ec-8dae-4a53-af98-627243c6ce25", "mechanic3@gms.ie", false, true, null, "Mechanic3", "MECHANIC3@GMS.IE", "MECHANIC3@GMS.IE", "AQAAAAEAACcQAAAAEJ3kClS3fSIi3jqmWF4qe74Y9GKIM1eOtDPlAQbT56zjaCGq7ohBqx9N1ySwNWLy4g==", "0834564597", false, "07d3cb98-de70-4edf-bfa0-aa011a1cadf4", false, "mechanic3@gms.ie" }
                });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "Id", "Deleted", "Group", "Name", "Value" },
                values: new object[,]
                {
                    { "b33f6c1e-db8f-4a28-be2b-7f8e28828a22", false, "Miscellaneous", "Engine computer and management system", 10.95m },
                    { "6fa41a8a-2934-42fa-bb24-de4d7c7d8191", false, "Braking System", "Anti-lock braking system (ABS) ", 150.45m },
                    { "6f581107-8787-4444-9161-5c9954be1a85", false, "Braking System", "Brake disc", 10.0m },
                    { "7e09bbdb-7173-408d-ae9b-e524b7c4e606", false, "Braking System", "Brake Fluid", 8.45m },
                    { "4edf7346-0e2d-4d5d-b09f-0505b8d7cdd5", false, "Braking System", "Brake pedal", 30.95m },
                    { "820e215b-14ff-4cc6-a300-b4ca085170c0", false, "Braking System", "Brake warning light", 3.5m },
                    { "ac93417a-e08b-4f53-86cf-74aadd79f3c0", false, "Braking System", "Park brake", 36.45m },
                    { "b0a38a09-643f-4d73-8c2d-0ea6f98277dc", false, "Braking System", "Tyre", 59.99m },
                    { "52e768b5-2ee9-49ea-9c2a-ca58dab01042", false, "Braking System", "Brake pump", 24.89m },
                    { "7dfcb764-1ffa-4bba-a14c-de4728312465", false, "Engine", "Diesel engine", 1647.8m },
                    { "f83409c5-5cdd-4ece-af55-7eb44f43c00f", false, "Engine", "Cylinder head", 85.4m },
                    { "28f8cdb7-9b99-4f8b-8d01-af86142fa9b5", false, "Engine", "Piston", 35.4m },
                    { "f34ae121-d21e-48e1-b905-76154cab4d56", false, "Engine", "Starter motor", 28.6m },
                    { "a9835046-890a-45ec-a155-5bb42d608e4b", false, "Engine", "Petrol engine (gasoline engine)", 789.5m },
                    { "9f1bf2a9-f240-42c6-aada-866c0863c6b4", false, "Cooling", "Radiator", 55.1m },
                    { "23f1cd34-bc61-4105-b624-909a9db2e3d4", false, "Cooling", "Cooling fan", 29.9m },
                    { "0f9bcf1b-996a-4884-9a79-1880d139aa0a", false, "Cooling", "Water tank", 35.4m },
                    { "6975f7e5-932f-4815-ba55-f6271dd71ac9", false, "Filter", "Oil filter", 15.00m },
                    { "56a2a5bb-cefb-4069-b64c-cb96aa4510ea", false, "Filter", "Air filter", 11.45m },
                    { "c0aa97da-bb9b-4cd0-a264-f473efbd281f", false, "Filter", "Fuel filter", 17.5m },
                    { "b9684291-3862-4c0e-92b5-e9097c28e606", false, "Miscellaneous", "Speed controller", 10.95m },
                    { "1be4f61b-75a8-4a84-8ba8-f918ff0748c7", false, "Electric", "Alternator", 120.0m },
                    { "ff18faa9-ac51-45ce-8ac8-3fa5ecf453c0", false, "Miscellaneous", "Transmission computer", 10.95m },
                    { "cf84a826-7ce4-4a8d-a319-5c0927f11c01", false, "Miscellaneous", "Fuse", 1.2m },
                    { "f54d2315-b554-4ff8-bdd9-1ebfa95a47f2", false, "Electric", "Battery", 50.5m },
                    { "dffcd7fa-68da-4eff-b800-4b0d166b3068", false, "Electric", "Battery Cable", 20.2m },
                    { "b1e5acb5-c57d-4c3d-8d54-e2db45bc9669", false, "Electric", "Voltage regulator", 3.1m },
                    { "4827e3e1-75dc-4f67-9501-555ed572b6de", false, "Electric", "Distilled Water", 5.4m },
                    { "7daf2f53-28f8-4e8c-ac79-eea2b58acb6b", false, "Ignition", "Sparking cable", 10.95m },
                    { "67ad0447-cd13-4027-8cc1-a643228d730f", false, "Ignition", "Ignition Coil", 8.45m },
                    { "0eece3c9-7aa8-4337-9bc5-df833ad5a81a", false, "Ignition", "Ignition box", 130.5m },
                    { "4ec7c8e0-c429-4232-a348-fc7df12b4f26", false, "Ignition", "Distributor", 10.95m },
                    { "6e4b77e5-a6f0-49c0-860c-3b22d245708e", false, "Miscellaneous", "GPS", 10.95m },
                    { "4b319c42-169f-4808-bff9-d7a5b0a90bd1", false, "Lighting", "Headlight", 24.7m }
                });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "Id", "Deleted", "Group", "Name", "Value" },
                values: new object[,]
                {
                    { "19f5d50c-137e-4259-987c-aa8e9150bc4e", false, "Lighting", "Spotlight", 9.95m },
                    { "5556125b-246b-40e1-b729-adc5041f0049", false, "Lighting", "Fog light", 4.95m },
                    { "c0ce3958-7471-4eb2-a1c2-15f3448f4f6e", false, "Lighting", "Brake light", 5.85m },
                    { "01820d03-7830-499d-a50e-6bb8eeaabc22", false, "Lighting", "Interior light", 8.0m },
                    { "ae268aaf-c02e-4fe8-9cec-48fd3873d273", false, "Sensor", "Fuel level sensor", 25.55m },
                    { "ad0bd7c2-d123-4bfe-b3c8-ed6b16e1b148", false, "Sensor", "Airbag sensors", 20.15m },
                    { "e26b5949-6060-4e79-b1ff-704f7bd88b20", false, "Sensor", "Oil level sensor", 15.0m },
                    { "40185a87-30e8-4234-ab90-38bf43b2204c", false, "Sensor", "Oil pressure sensor", 30.99m },
                    { "26989f20-8f17-49a0-8cc3-a5ff3f6522f9", false, "Sensor", "Coolant temperature sensor", 20.65m },
                    { "39a62df0-ee2b-4389-88dd-4013612d0b09", false, "Miscellaneous", "Air bag control module", 56.79m },
                    { "86124efb-4b4c-4ace-b553-20cfefc422db", false, "Miscellaneous", "Alarm and siren", 25.45m },
                    { "8ab45b3f-ec15-4dab-be15-3144f918dc06", false, "Miscellaneous", "Central locking system", 40.9m },
                    { "b84141b8-b3a4-4d0d-b780-f0a7baae40eb", false, "Lighting", "Turn signal", 4.75m },
                    { "65481cc5-5488-495c-9a56-bee704198d42", false, "Miscellaneous", "Fuse Box", 11.55m }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Deleted", "Group", "Name", "Value" },
                values: new object[,]
                {
                    { "29b3cb11-a857-4596-8eb2-4909729354b5", false, "Main", "Annual Service", 120.0m },
                    { "0616d08e-78d5-4ff8-abd6-dcd2c53229bd", false, "Main", "Major Service", 120.0m },
                    { "e86a9c49-a7b0-4f93-99b4-d386ad0e0b8d", false, "Main", "Repair / Fault", 120.0m },
                    { "2ee7195e-b47c-400d-afe5-9cd2cc71eab8", false, "Main", "Major Repair", 120.0m }
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
                keyValue: "01820d03-7830-499d-a50e-6bb8eeaabc22");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "0eece3c9-7aa8-4337-9bc5-df833ad5a81a");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "0f9bcf1b-996a-4884-9a79-1880d139aa0a");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "19f5d50c-137e-4259-987c-aa8e9150bc4e");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "1be4f61b-75a8-4a84-8ba8-f918ff0748c7");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "23f1cd34-bc61-4105-b624-909a9db2e3d4");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "26989f20-8f17-49a0-8cc3-a5ff3f6522f9");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "28f8cdb7-9b99-4f8b-8d01-af86142fa9b5");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "39a62df0-ee2b-4389-88dd-4013612d0b09");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "40185a87-30e8-4234-ab90-38bf43b2204c");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4827e3e1-75dc-4f67-9501-555ed572b6de");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4b319c42-169f-4808-bff9-d7a5b0a90bd1");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4ec7c8e0-c429-4232-a348-fc7df12b4f26");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4edf7346-0e2d-4d5d-b09f-0505b8d7cdd5");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "52e768b5-2ee9-49ea-9c2a-ca58dab01042");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "5556125b-246b-40e1-b729-adc5041f0049");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "56a2a5bb-cefb-4069-b64c-cb96aa4510ea");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "65481cc5-5488-495c-9a56-bee704198d42");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "67ad0447-cd13-4027-8cc1-a643228d730f");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "6975f7e5-932f-4815-ba55-f6271dd71ac9");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "6e4b77e5-a6f0-49c0-860c-3b22d245708e");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "6f581107-8787-4444-9161-5c9954be1a85");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "6fa41a8a-2934-42fa-bb24-de4d7c7d8191");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "7daf2f53-28f8-4e8c-ac79-eea2b58acb6b");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "7dfcb764-1ffa-4bba-a14c-de4728312465");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "7e09bbdb-7173-408d-ae9b-e524b7c4e606");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "820e215b-14ff-4cc6-a300-b4ca085170c0");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "86124efb-4b4c-4ace-b553-20cfefc422db");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "8ab45b3f-ec15-4dab-be15-3144f918dc06");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "9f1bf2a9-f240-42c6-aada-866c0863c6b4");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "a9835046-890a-45ec-a155-5bb42d608e4b");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "ac93417a-e08b-4f53-86cf-74aadd79f3c0");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "ad0bd7c2-d123-4bfe-b3c8-ed6b16e1b148");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "ae268aaf-c02e-4fe8-9cec-48fd3873d273");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b0a38a09-643f-4d73-8c2d-0ea6f98277dc");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b1e5acb5-c57d-4c3d-8d54-e2db45bc9669");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b33f6c1e-db8f-4a28-be2b-7f8e28828a22");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b84141b8-b3a4-4d0d-b780-f0a7baae40eb");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b9684291-3862-4c0e-92b5-e9097c28e606");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "c0aa97da-bb9b-4cd0-a264-f473efbd281f");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "c0ce3958-7471-4eb2-a1c2-15f3448f4f6e");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "cf84a826-7ce4-4a8d-a319-5c0927f11c01");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "dffcd7fa-68da-4eff-b800-4b0d166b3068");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "e26b5949-6060-4e79-b1ff-704f7bd88b20");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "f34ae121-d21e-48e1-b905-76154cab4d56");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "f54d2315-b554-4ff8-bdd9-1ebfa95a47f2");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "f83409c5-5cdd-4ece-af55-7eb44f43c00f");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "ff18faa9-ac51-45ce-8ac8-3fa5ecf453c0");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "0616d08e-78d5-4ff8-abd6-dcd2c53229bd");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "29b3cb11-a857-4596-8eb2-4909729354b5");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "2ee7195e-b47c-400d-afe5-9cd2cc71eab8");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "e86a9c49-a7b0-4f93-99b4-d386ad0e0b8d");

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
