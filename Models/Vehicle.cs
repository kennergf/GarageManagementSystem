using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Models
{
    public class Vehicle
    {
        public string Id { get; set; }
        public string Licence { get; set; }
        public CarType Type { get; set; }
        public EngineType EngineType { get; set; }
    }
}