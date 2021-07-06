using System;
using System.ComponentModel.DataAnnotations;
using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Models
{
    public class Booking
    {
        [Key]
        public string Id { get; set; }
        public ApplicationUser Customer { get; set; }
        public BookingType BookingType { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}