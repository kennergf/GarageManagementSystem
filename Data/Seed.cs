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

        // REF https://stackoverflow.com/questions/2344098/c-sharp-how-to-create-a-guid-value#2344107
        // REF https://docs.microsoft.com/en-us/dotnet/api/system.guid.tostring?redirectedfrom=MSDN&view=net-5.0#System_Guid_ToString_System_String_
        internal static void Services(ModelBuilder builder)
        {
            var services = new List<Service>();

            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Annual Service",
                Value = 120.0M,
                Group = "Main",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Major Service",
                Value = 120.0M,
                Group = "Main",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Repair / Fault",
                Value = 120.0M,
                Group = "Main",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Major Repair",
                Value = 120.0M,
                Group = "Main",
            });
            // REF https://mannysmechanicalrepairs.com.au/services/complete-list-of-services/
            // Brake
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Front And Rear Disc Brake Pad Replacement",
                Value = 35.0M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Cylinder Replacement",
                Value = 45.0M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Master Cylinder Replacement Or Reconditioning",
                Value = 58.60M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Caliper Overhaul",
                Value = 13.0M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Fluid Replacement",
                Value = 16.05M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Adjustment",
                Value = 25.0M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Pipe Replacement",
                Value = 34.50M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Shoe Replacement",
                Value = 49.0M,
                Group = "Brake",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Abs Module Replacement And Diagnosing",
                Value = 55.40M,
                Group = "Brake",
            });
            // Electrical
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Computer Fault Scaning And Diagnosis",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Starter Motor Replacement",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Charging System Testing",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Alternator Replacement",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Small Wiring Repairs",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Electric Window Repairs",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Head Light and Tail Light Repairs",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Ignition Testing",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Battery Testing and Replacing",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Ignition Module Testing And Replacing",
                Value = 55.40M,
                Group = "Electrical Repairs",
            });
            //Fuel
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Leaky Fuel Injector Repairs",
                Value = 35.60M,
                Group = "Fuel Injection",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuel Hose Replacement",
                Value = 55.0M,
                Group = "Fuel Injection",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuel Pump Replacement",
                Value = 15.50M,
                Group = "Fuel Injection",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Sensor Testing",
                Value = 14.0M,
                Group = "Fuel Injection",
            });
            // Suspension
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Suspension Checks",
                Value = 25.30M,
                Group = "Suspension and Steering",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Shock Absorber Replacement",
                Value = 45.80M,
                Group = "Suspension and Steering",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Ball Joints and Tie Rod End Replacement",
                Value = 35.0M,
                Group = "Suspension and Steering",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Suspension Springs Replaced ",
                Value = 45.90M,
                Group = "Suspension and Steering",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Wheel Alignment",
                Value = 16.50M,
                Group = "Suspension and Steering",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Front Wheel Bearing Replacement",
                Value = 55.40M,
                Group = "Suspension and Steering",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Rear Axle Bearings And Seals Replacement",
                Value = 45.0M,
                Group = "Suspension and Steering",
            });
            // Cooling System
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Thermofan Replacement",
                Value = 23.0M,
                Group = "Cooling System",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fan & Drive Belt Replacment",
                Value = 14.20M,
                Group = "Cooling System",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Cooling System Leakage Tests",
                Value = 18.0M,
                Group = "Cooling System",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Radiator Replacement",
                Value = 58.05M,
                Group = "Cooling System",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Water Pump Replacement",
                Value = 25.10M,
                Group = "Cooling System",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Heater Hose and Heater Tap Replacement",
                Value = 35.40M,
                Group = "Cooling System",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Coolant Flush Replacement",
                Value = 25.0M,
                Group = "Cooling System",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Radiator Hose, Thermostat Replacement",
                Value = 54.10M,
                Group = "Cooling System",
            });
            // Engine
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Car Cylinder Head Reconditioning",
                Value = 156.50M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Compression Tests",
                Value = 46.10M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Vacuum Testing",
                Value = 26.0M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Throtle Body Cleaning",
                Value = 36.40M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Gas Analyser Checks",
                Value = 19.0M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Manifold Gasket & Exhaust Repairs",
                Value = 24.60M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Car Points Replacement",
                Value = 35.20M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Timing Belt Replacement",
                Value = 14.20M,
                Group = "Engine",
            });
            services.Add(new Service
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Prepurchase Inspections",
                Value = 55.10M,
                Group = "Engine",
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
                Group = "Electric",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Battery",
                Value = 50.5M,
                Group = "Electric",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Battery Cable",
                Value = 20.2M,
                Group = "Electric",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Voltage regulator",
                Value = 3.1M,
                Group = "Electric",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Distilled Water",
                Value = 5.4M,
                Group = "Electric",
            });
            // Ignition
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Sparking cable",
                Value = 10.95M,
                Group = "Ignition",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Ignition Coil",
                Value = 8.45M,
                Group = "Ignition",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Ignition box",
                Value = 130.5M,
                Group = "Ignition",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Distributor",
                Value = 10.95M,
                Group = "Ignition",
            });
            // Lighting
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fog light",
                Value = 4.95M,
                Group = "Lighting",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Headlight",
                Value = 24.7M,
                Group = "Lighting",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Spotlight",
                Value = 9.95M,
                Group = "Lighting",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Turn signal",
                Value = 4.75M,
                Group = "Lighting",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake light",
                Value = 5.85M,
                Group = "Lighting",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Interior light",
                Value = 8.0M,
                Group = "Lighting",
            });
            // Sensor
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuel level sensor",
                Value = 25.55M,
                Group = "Sensor",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Airbag sensors",
                Value = 20.15M,
                Group = "Sensor",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Oil level sensor",
                Value = 15.0M,
                Group = "Sensor",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Oil pressure sensor",
                Value = 30.99M,
                Group = "Sensor",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Coolant temperature sensor",
                Value = 20.65M,
                Group = "Sensor",
            });
            // Miscellaneous
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Air bag control module",
                Value = 56.79M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Alarm and siren",
                Value = 25.45M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Central locking system",
                Value = 40.9M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuse",
                Value = 1.2M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuse Box",
                Value = 11.55M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "GPS",
                Value = 10.95M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Speed controller",
                Value = 10.95M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Transmission computer",
                Value = 10.95M,
                Group = "Miscellaneous",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Engine computer and management system",
                Value = 10.95M,
                Group = "Miscellaneous",
            });
            // Braking System 
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Anti-lock braking system (ABS) ",
                Value = 150.45M,
                Group = "Braking System",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake disc",
                Value = 10.0M,
                Group = "Braking System",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake Fluid",
                Value = 8.45M,
                Group = "Braking System",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake pedal",
                Value = 30.95M,
                Group = "Braking System",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake warning light",
                Value = 3.5M,
                Group = "Braking System",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Park brake",
                Value = 36.45M,
                Group = "Braking System",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Tyre",
                Value = 59.99M,
                Group = "Braking System",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Brake pump",
                Value = 24.89M,
                Group = "Braking System",
            });
            // Engine
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Diesel engine",
                Value = 1647.8M,
                Group = "Engine",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Cylinder head",
                Value = 85.4M,
                Group = "Engine",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Piston",
                Value = 35.4M,
                Group = "Engine",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Starter motor",
                Value = 28.6M,
                Group = "Engine",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Petrol engine (gasoline engine)",
                Value = 789.5M,
                Group = "Engine",
            });
            // Cooling
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Radiator",
                Value = 55.1M,
                Group = "Cooling",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Cooling fan",
                Value = 29.9M,
                Group = "Cooling",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Water tank",
                Value = 35.4M,
                Group = "Cooling",
            });
            // Filter
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Oil filter",
                Value = 15.00M,
                Group = "Filter",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Air filter",
                Value = 11.45M,
                Group = "Filter",
            });
            parts.Add(new Part
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = "Fuel filter",
                Value = 17.5M,
                Group = "Filter",
            });
            builder.Entity<Part>().HasData(parts);
        }

        #endregion

    }
}