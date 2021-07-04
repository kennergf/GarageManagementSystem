using System.Collections.Generic;

namespace GarageManagementSystem.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}