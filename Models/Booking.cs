using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Models
{
    public class Booking
    {
        public Customer Customer { get; set; }
        public BookingType BookingType { get; set; }
        public string Comment { get; set; }
    }
}