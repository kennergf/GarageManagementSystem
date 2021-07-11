using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string CustomerId { get; set; }

        [Required]
        public ApplicationUser Customer { get; set; }

        [ForeignKey("Vehicle")]
        public string VehicleId { get; set; }

        [Required]
        public Vehicle Vehicle { get; set; }

        public BookingType BookingType { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Comment { get; set; }
    }
}