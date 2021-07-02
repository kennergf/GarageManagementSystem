using System.Collections.Generic;

namespace GarageManagementSystem.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}