using System;
using System.Collections.Generic;
using GarageManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GarageManagementSystem.Data
{
    internal static class Seed
    {
        #region Users

        // REF https://www.c-sharpcorner.com/article/seed-data-in-net-core-identity/
        internal static void Users(ModelBuilder builder)
        {
            var users = new List<ApplicationUser>();
            users.Add(new ApplicationUser()
            {
                Id = "d42eb8c8-2232-406b-9bc0-3859863f064c",
                UserName = "admin@gms.ie",
                NormalizedUserName = "ADMIN@GMS.IE",
                Name = "Admin",
                Email = "admin@gms.ie",
                NormalizedEmail = "ADMIN@GMS.IE",
                PhoneNumber = "014569145",
                LockoutEnabled = true,
            });
            users.Add(new ApplicationUser()
            {
                Id = "160453a8-8e19-4f70-9b61-3f6f37d82a3a",
                UserName = "mechanic1@gms.ie",
                NormalizedUserName = "MECHANIC1@GMS.IE",
                Name = "Mechanic1",
                Email = "mechanic1@gms.ie",
                NormalizedEmail = "MECHANIC1@GMS.IE",
                PhoneNumber = "0834564578",
                LockoutEnabled = true,
            });
            users.Add(new ApplicationUser()
            {
                Id = "cab9f1df-6d5c-40ae-b05a-be0d0d379f55",
                UserName = "mechanic2@gms.ie",
                NormalizedUserName = "MECHANIC2@GMS.IE",
                Name = "Mechanic2",
                Email = "mechanic2@gms.ie",
                NormalizedEmail = "MECHANIC2@GMS.IE",
                PhoneNumber = "0834564536",
                LockoutEnabled = true,
            });
            users.Add(new ApplicationUser()
            {
                Id = "990d5d6b-e4b1-4978-accc-5065754d1632",
                UserName = "mechanic3@gms.ie",
                NormalizedUserName = "MECHANIC3@GMS.IE",
                Name = "Mechanic3",
                Email = "mechanic3@gms.ie",
                NormalizedEmail = "MECHANIC3@GMS.IE",
                PhoneNumber = "0834564597",
                LockoutEnabled = true,
            });
            users.Add(new ApplicationUser()
            {
                Id = "98857515-b584-464e-850c-5047904de7f7",
                UserName = "mechanic4@gms.ie",
                NormalizedUserName = "MECHANIC4@GMS.IE",
                Name = "Mechanic4",
                Email = "mechanic4@gms.ie",
                NormalizedEmail = "MECHANIC4@GMS.IE",
                PhoneNumber = "0834564571",
                LockoutEnabled = true,
            });

            // REF https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.passwordhasher-1?view=aspnetcore-5.0
            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
            foreach (var user in users)
            {
                user.PasswordHash = hasher.HashPassword(user, "Cct@2021");
                builder.Entity<ApplicationUser>().HasData(user);
            }
        }

        internal static void Roles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "e3d4f4a2-1c98-486d-bc8d-1773e3766bb4", Name = "Administrator", ConcurrencyStamp = "7d36eb1e-f28b-4984-b8f8-ccd44b6f11c9", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole() { Id = "b09f1e6f-0574-4589-9c08-44d22a208054", Name = "Customer", ConcurrencyStamp = "aaeb9d55-3071-40d0-8d46-8c1b121751fb", NormalizedName = "CUSTOMER" },
                new IdentityRole() { Id = "ef38b05c-8be4-4162-a344-1eec9d231943", Name = "Mechanic", ConcurrencyStamp = "2d137420-c535-4fb7-9f32-801e44f4c7d4", NormalizedName = "MECHANIC" }
                );
        }

        internal static void UserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "e3d4f4a2-1c98-486d-bc8d-1773e3766bb4",
                    UserId = "d42eb8c8-2232-406b-9bc0-3859863f064c"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "ef38b05c-8be4-4162-a344-1eec9d231943",
                    UserId = "160453a8-8e19-4f70-9b61-3f6f37d82a3a"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "ef38b05c-8be4-4162-a344-1eec9d231943",
                    UserId = "cab9f1df-6d5c-40ae-b05a-be0d0d379f55"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "ef38b05c-8be4-4162-a344-1eec9d231943",
                    UserId = "990d5d6b-e4b1-4978-accc-5065754d1632"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "ef38b05c-8be4-4162-a344-1eec9d231943",
                    UserId = "98857515-b584-464e-850c-5047904de7f7"
                }
                );
        }

        #endregion

        #region Service

        internal static void Services(ModelBuilder builder)
        {
            var services = new List<Service>();
            // Electric
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Annual Service",
                Value = 120.0M,
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Major Service",
                Value = 120.0M,
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Repair / Fault",
                Value = 120.0M,
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Major Repair",
                Value = 120.0M,
            });
            builder.Entity<Service>().HasData(services);
        }

        #endregion

        #region Part

        internal static void Parts(ModelBuilder builder)
        {
            var parts = new List<Part>();
            // Electric
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Alternator",
                Value = 120.0M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Battery",
                Value = 50.5M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Battery Cable",
                Value = 20.2M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Voltage regulator",
                Value = 3.1M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Distilled Water",
                Value = 5.4M,
            });
            // Ignition
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Sparking cable",
                Value = 10.95M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Ignition Coil",
                Value = 8.45M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Ignition box",
                Value = 130.5M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Distributor",
                Value = 10.95M,
            });
            // Lighting
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fog light",
                Value = 4.95M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Headlight",
                Value = 24.7M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Spotlight",
                Value = 9.95M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Turn signal",
                Value = 4.75M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake light",
                Value = 5.85M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Interior light",
                Value = 8.0M,
            });
            // Sensor
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuel level sensor",
                Value = 25.55M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Airbag sensors",
                Value = 20.15M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Oil level sensor",
                Value = 15.0M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Oil pressure sensor",
                Value = 30.99M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Coolant temperature sensor",
                Value = 20.65M,
            });
            // Miscellaneous
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Air bag control module",
                Value = 56.79M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Alarm and siren",
                Value = 25.45M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Central locking system",
                Value = 40.9M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuse",
                Value = 1.2M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuse Box",
                Value = 11.55M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "GPS",
                Value = 10.95M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Speed controller",
                Value = 10.95M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Transmission computer",
                Value = 10.95M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Engine computer and management system",
                Value = 10.95M,
            });
            // Braking System 
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Anti-lock braking system (ABS) ",
                Value = 150.45M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake disc",
                Value = 10.0M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Fluid",
                Value = 8.45M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake pedal",
                Value = 30.95M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake warning light",
                Value = 3.5M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Park brake",
                Value = 36.45M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Tyre",
                Value = 59.99M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake pump",
                Value = 24.89M,
            });
            // Engine
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Diesel engine",
                Value = 1647.8M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Cylinder head",
                Value = 85.4M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Piston",
                Value = 35.4M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Starter motor",
                Value = 28.6M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Petrol engine (gasoline engine)",
                Value = 789.5M,
            });
            // Cooling
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Radiator",
                Value = 55.1M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Cooling fan",
                Value = 29.9M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Water tank",
                Value = 35.4M,
            });
            // Filter
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Oil filter",
                Value = 15.00M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Air filter",
                Value = 11.45M,
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuel filter",
                Value = 17.5M,
            });
            builder.Entity<Part>().HasData(parts);
        }

        #endregion

    }
}