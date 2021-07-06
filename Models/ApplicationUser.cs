using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace GarageManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public string Id { get; set; }
        //public string Name { get; set; }
        //public string Phone { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}