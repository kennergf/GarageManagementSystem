using GarageManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GarageManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Part>()
                .Property(p => p.Value)
                .HasPrecision(18, 2);
        }

        public DbSet<GarageManagementSystem.Models.Vehicle> Vehicle { get; set; }
        public DbSet<GarageManagementSystem.Models.Booking> Booking { get; set; }
        public DbSet<GarageManagementSystem.Models.Part> Part { get; set; }
    }
}
