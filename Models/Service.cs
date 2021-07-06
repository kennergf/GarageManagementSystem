using System.ComponentModel.DataAnnotations;

namespace GarageManagementSystem.Models
{
    public class Service
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}