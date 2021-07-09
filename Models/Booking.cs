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

        public ApplicationUser Customer { get; set; }

        [Required]
        public Vehicle Vehicle { get; set; }

        public BookingType BookingType { get; set; }

        [Required]
        public DateTime Date { get; set; }
        
        public string Comment { get; set; }
    }
}