using System;
using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Models
{
    public class Booking
    {
        public string Id { get; set; }
        public Customer Customer { get; set; }
        public BookingType BookingType { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}