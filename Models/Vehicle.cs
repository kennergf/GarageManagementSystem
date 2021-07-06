using System.ComponentModel.DataAnnotations;
using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Models
{
    public class Vehicle
    {
        [Key]
        public string Id { get; set; }
        public string Licence { get; set; }
        public CarType Type { get; set; }
        public EngineType EngineType { get; set; }
    }
}