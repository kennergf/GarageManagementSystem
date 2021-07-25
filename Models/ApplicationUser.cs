using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GarageManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public string Phone { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}