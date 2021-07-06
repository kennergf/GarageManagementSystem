using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        /// <summary>
        /// When Deleted, it can not be used for new services
        /// </summary>
        /// <value></value>
        public bool Deleted { get; set; }
        public string Licence { get; set; }
        public CarType Type { get; set; }

        [Display(Name = "Engine Type")]
        public EngineType EngineType { get; set; }
    }
}