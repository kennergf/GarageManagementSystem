using System.ComponentModel.DataAnnotations;

namespace GarageManagementSystem.Models
{
    public class Part
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}