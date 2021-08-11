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
                    { "98857515-b584-464e-850c-5047904de7f7", 0, "d38e1f40-44b0-4080-a4a3-004e005db08f", "mechanic4@gms.ie", false, true, null, "Mechanic4", "MECHANIC4@GMS.IE", "MECHANIC4@GMS.IE", "AQAAAAEAACcQAAAAED2NECljyc9oqFYBXdJ0RTa1ZjcfEgs58DC+184CDIBe4SvVfF/yUyd9v+GvDhymrw==", "0834564571", false, "bc98965d-2e52-4538-a4bc-8952c611a398", false, "mechanic4@gms.ie" },
                    { "d42eb8c8-2232-406b-9bc0-3859863f064c", 0, "ea626e9f-8bf7-48f1-86fd-30ad5d189f69", "admin@gms.ie", false, true, null, "Admin", "ADMIN@GMS.IE", "ADMIN@GMS.IE", "AQAAAAEAACcQAAAAEMz9bWyqbD2nY23BFk96SBhn64ZLC07JbvfUd/dRwrOXdpbT0wiaaOrcSkk1l//GGg==", "014569145", false, "23ac688c-8701-4335-b597-9f1a2c5877fa", false, "admin@gms.ie" },
                    { "cab9f1df-6d5c-40ae-b05a-be0d0d379f55", 0, "f887abc1-88ba-47a6-a996-c701da722c8a", "mechanic2@gms.ie", false, true, null, "Mechanic2", "MECHANIC2@GMS.IE", "MECHANIC2@GMS.IE", "AQAAAAEAACcQAAAAEFYlRdb9rgLBpSn+TyMD1vvxpDABeuNCprPh1TFI8kT+w3QEMqhQCBXWhsqTCTqROw==", "0834564536", false, "f5add130-1829-4155-b12d-4eab659a5cac", false, "mechanic2@gms.ie" },
                    { "160453a8-8e19-4f70-9b61-3f6f37d82a3a", 0, "4fd928f9-efc5-4ea3-ac52-defefeb913e3", "mechanic1@gms.ie", false, true, null, "Mechanic1", "MECHANIC1@GMS.IE", "MECHANIC1@GMS.IE", "AQAAAAEAACcQAAAAEN70EFGj2hwETRyBu7r6m20vNUJvmgWIjD3xBcc76F4wHyArKD1ZdYRgPLWJlsisUQ==", "0834564578", false, "f2b47994-b60b-4d06-aa88-9474ae0e90fd", false, "mechanic1@gms.ie" },
                    { "990d5d6b-e4b1-4978-accc-5065754d1632", 0, "baf4859f-767a-4ea1-92ac-2c1c30558c6a", "mechanic3@gms.ie", false, true, null, "Mechanic3", "MECHANIC3@GMS.IE", "MECHANIC3@GMS.IE", "AQAAAAEAACcQAAAAEKbTwf8qFDYFQWFEmxA+xB0yYhVqRXFQuJEYFcqSrdXPeAMhhNK2VVc6DiflOUJENg==", "0834564597", false, "d3b60a4b-04f1-46e3-91db-ca101e9c9c80", false, "mechanic3@gms.ie" }
                });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "Id", "Deleted", "Group", "Name", "Value" },
                values: new object[,]
                {
                    { "633990ed-8a97-46d4-8cd2-9dafe70611e4", false, "Miscellaneous", "Engine computer and management system", 10.95m },
                    { "fdb3f313-f602-438a-92f9-9149f19fda7b", false, "Braking System", "Anti-lock braking system (ABS) ", 150.45m },
                    { "f83dc4b4-8b53-428e-89f5-07c2227ee9fc", false, "Braking System", "Brake disc", 10.0m },
                    { "16340c2f-f47a-45bd-a9cb-e398ed8ce2a8", false, "Braking System", "Brake Fluid", 8.45m },
                    { "d5977c81-b10e-4fab-8711-7475b86e3980", false, "Braking System", "Brake pedal", 30.95m },
                    { "b7df2393-004d-413c-96e3-f3d4ff1da982", false, "Braking System", "Brake warning light", 3.5m },
                    { "e53eedc9-6029-4dcc-81e4-23b5a57c8a0e", false, "Braking System", "Park brake", 36.45m },
                    { "419546c7-fc0f-4b71-bf81-d5144c0d7f36", false, "Braking System", "Tyre", 59.99m },
                    { "fa4228aa-5e40-4fca-9ee7-b7d35402330a", false, "Braking System", "Brake pump", 24.89m },
                    { "da3d5e2f-3d2e-4284-8273-6fbcd8e9e583", false, "Engine", "Diesel engine", 1647.8m },
                    { "397a1635-5318-488f-8b3d-e4c8450d25e7", false, "Engine", "Cylinder head", 85.4m },
                    { "6c631c29-91b6-437c-90a3-a323c04403e2", false, "Engine", "Piston", 35.4m },
                    { "4f41669f-bdf2-4712-b90c-e7050c19f9f5", false, "Engine", "Starter motor", 28.6m },
                    { "87dfb7ac-910e-4a2e-908f-c112206a52be", false, "Engine", "Petrol engine (gasoline engine)", 789.5m },
                    { "7ac99a7f-f9c5-400c-9ae5-8bef95eedd1d", false, "Cooling", "Radiator", 55.1m },
                    { "c5316643-bdd9-4d25-93b2-abaf5240ac57", false, "Cooling", "Cooling fan", 29.9m },
                    { "19efef04-a680-499b-b609-4c2b60f39e6c", false, "Cooling", "Water tank", 35.4m },
                    { "53b02644-b94a-453b-a7bc-efc43626997b", false, "Filter", "Oil filter", 15.00m },
                    { "e204a036-4bb6-4f05-bc2c-8b66d2d598f2", false, "Filter", "Air filter", 11.45m },
                    { "c68f7260-262f-4118-8e54-5154cead0106", false, "Filter", "Fuel filter", 17.5m },
                    { "01b99afb-8cce-45e6-a728-7bf21c536b02", false, "Miscellaneous", "Speed controller", 10.95m },
                    { "ddb41b99-4711-42df-a4a9-eed637f6ccef", false, "Electric", "Alternator", 120.0m },
                    { "eb73dcd7-b73e-498e-ac29-eebd6c7ae816", false, "Miscellaneous", "Transmission computer", 10.95m },
                    { "2c6d4a5a-8166-47ea-8094-b837fcd2c515", false, "Miscellaneous", "Fuse", 1.2m },
                    { "866e727e-b0f9-4e9f-8bc3-ed8f8bbfddb8", false, "Electric", "Battery", 50.5m },
                    { "971e881a-ce0b-448b-b7f0-a77d6ea9d19e", false, "Electric", "Battery Cable", 20.2m },
                    { "bf5d835f-bc67-425a-94c1-a4802d1790fa", false, "Electric", "Voltage regulator", 3.1m },
                    { "8ca38b99-1433-493f-a45a-985622309527", false, "Electric", "Distilled Water", 5.4m },
                    { "b1ca8ec6-cbe6-4c0c-aa36-c22d922ba029", false, "Ignition", "Sparking cable", 10.95m },
                    { "1c78fff5-d3cf-4d51-986f-e4423d7fdeb0", false, "Ignition", "Ignition Coil", 8.45m },
                    { "548a06d3-e329-4706-8881-cba34905a531", false, "Ignition", "Ignition box", 130.5m },
                    { "632875ca-fe68-4d2b-b581-3e0187cb9fab", false, "Ignition", "Distributor", 10.95m },
                    { "4a5b90be-87fb-4c50-8c83-988f685a0a8d", false, "Miscellaneous", "GPS", 10.95m },
                    { "6bb33ce9-170d-4eb3-b687-5727a27fb9e0", false, "Lighting", "Headlight", 24.7m }
                });

            migrationBuilder.InsertData(
                table: "Part",
                columns: new[] { "Id", "Deleted", "Group", "Name", "Value" },
                values: new object[,]
                {
                    { "f620ac69-aa4c-4cb3-ae11-35eb7237b888", false, "Lighting", "Spotlight", 9.95m },
                    { "1055c072-599d-403d-a70a-3e5b2b80cf08", false, "Lighting", "Fog light", 4.95m },
                    { "2108e839-9a2a-45e4-9709-719c96e40006", false, "Lighting", "Brake light", 5.85m },
                    { "8ad0856f-f068-4b4d-8e90-0f54c447df4b", false, "Lighting", "Interior light", 8.0m },
                    { "31a8381d-361a-4a46-9f85-3a7c297a6920", false, "Sensor", "Fuel level sensor", 25.55m },
                    { "eb9e8c2e-5f7a-474c-aa05-e919d4ef9a35", false, "Sensor", "Airbag sensors", 20.15m },
                    { "2b4a765c-b48a-40c7-877a-a2c7ebcfb549", false, "Sensor", "Oil level sensor", 15.0m },
                    { "50b02451-d226-41dc-98ab-557dc02918f4", false, "Sensor", "Oil pressure sensor", 30.99m },
                    { "0b257d41-3c15-47cc-9c02-0142d7ad3300", false, "Sensor", "Coolant temperature sensor", 20.65m },
                    { "9ea889bd-1e82-4178-8092-cdc0d838d32c", false, "Miscellaneous", "Air bag control module", 56.79m },
                    { "42de5c62-55aa-4603-a4ac-87d7092e6d01", false, "Miscellaneous", "Alarm and siren", 25.45m },
                    { "94cd0a5c-3f90-421a-9558-ac2a7c3954a2", false, "Miscellaneous", "Central locking system", 40.9m },
                    { "8f2fc967-bba7-4997-a05b-f931d172433e", false, "Lighting", "Turn signal", 4.75m },
                    { "68e6630f-c83b-4c18-a362-808422933bbf", false, "Miscellaneous", "Fuse Box", 11.55m }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Deleted", "Group", "Name", "Value" },
                values: new object[,]
                {
                    { "ffa83757-2c4d-459a-b973-0719066dae02", false, "Main", "Annual Service", 120.0m },
                    { "31096fae-7726-4aa9-85d2-97f8c075c9ab", false, "Main", "Major Service", 120.0m },
                    { "5d1919ec-6e44-44d0-9710-f2b23c0b2c22", false, "Main", "Repair / Fault", 120.0m },
                    { "020abf47-bb76-45b8-90b0-d960ccd65226", false, "Main", "Major Repair", 120.0m }
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
                keyValue: "01b99afb-8cce-45e6-a728-7bf21c536b02");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "0b257d41-3c15-47cc-9c02-0142d7ad3300");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "1055c072-599d-403d-a70a-3e5b2b80cf08");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "16340c2f-f47a-45bd-a9cb-e398ed8ce2a8");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "19efef04-a680-499b-b609-4c2b60f39e6c");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "1c78fff5-d3cf-4d51-986f-e4423d7fdeb0");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "2108e839-9a2a-45e4-9709-719c96e40006");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "2b4a765c-b48a-40c7-877a-a2c7ebcfb549");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "2c6d4a5a-8166-47ea-8094-b837fcd2c515");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "31a8381d-361a-4a46-9f85-3a7c297a6920");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "397a1635-5318-488f-8b3d-e4c8450d25e7");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "419546c7-fc0f-4b71-bf81-d5144c0d7f36");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "42de5c62-55aa-4603-a4ac-87d7092e6d01");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4a5b90be-87fb-4c50-8c83-988f685a0a8d");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "4f41669f-bdf2-4712-b90c-e7050c19f9f5");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "50b02451-d226-41dc-98ab-557dc02918f4");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "53b02644-b94a-453b-a7bc-efc43626997b");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "548a06d3-e329-4706-8881-cba34905a531");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "632875ca-fe68-4d2b-b581-3e0187cb9fab");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "633990ed-8a97-46d4-8cd2-9dafe70611e4");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "68e6630f-c83b-4c18-a362-808422933bbf");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "6bb33ce9-170d-4eb3-b687-5727a27fb9e0");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "6c631c29-91b6-437c-90a3-a323c04403e2");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "7ac99a7f-f9c5-400c-9ae5-8bef95eedd1d");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "866e727e-b0f9-4e9f-8bc3-ed8f8bbfddb8");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "87dfb7ac-910e-4a2e-908f-c112206a52be");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "8ad0856f-f068-4b4d-8e90-0f54c447df4b");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "8ca38b99-1433-493f-a45a-985622309527");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "8f2fc967-bba7-4997-a05b-f931d172433e");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "94cd0a5c-3f90-421a-9558-ac2a7c3954a2");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "971e881a-ce0b-448b-b7f0-a77d6ea9d19e");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "9ea889bd-1e82-4178-8092-cdc0d838d32c");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b1ca8ec6-cbe6-4c0c-aa36-c22d922ba029");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "b7df2393-004d-413c-96e3-f3d4ff1da982");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "bf5d835f-bc67-425a-94c1-a4802d1790fa");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "c5316643-bdd9-4d25-93b2-abaf5240ac57");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "c68f7260-262f-4118-8e54-5154cead0106");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "d5977c81-b10e-4fab-8711-7475b86e3980");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "da3d5e2f-3d2e-4284-8273-6fbcd8e9e583");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "ddb41b99-4711-42df-a4a9-eed637f6ccef");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "e204a036-4bb6-4f05-bc2c-8b66d2d598f2");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "e53eedc9-6029-4dcc-81e4-23b5a57c8a0e");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "eb73dcd7-b73e-498e-ac29-eebd6c7ae816");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "eb9e8c2e-5f7a-474c-aa05-e919d4ef9a35");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "f620ac69-aa4c-4cb3-ae11-35eb7237b888");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "f83dc4b4-8b53-428e-89f5-07c2227ee9fc");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "fa4228aa-5e40-4fca-9ee7-b7d35402330a");

            migrationBuilder.DeleteData(
                table: "Part",
                keyColumn: "Id",
                keyValue: "fdb3f313-f602-438a-92f9-9149f19fda7b");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "020abf47-bb76-45b8-90b0-d960ccd65226");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "31096fae-7726-4aa9-85d2-97f8c075c9ab");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "5d1919ec-6e44-44d0-9710-f2b23c0b2c22");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: "ffa83757-2c4d-459a-b973-0719066dae02");

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
