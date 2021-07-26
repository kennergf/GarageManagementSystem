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

        [ForeignKey("ApplicationUser")]
        public string MechanicId { get; set; }

        public ApplicationUser Mechanic { get; set; }

        [Display(Name = "Booking Type")]
        public BookingType BookingType { get; set; }

        [Required, Display(Name = "Date of Booking")]
        public DateTime Date { get; set; }

        public Status Status { get; private set; }

        public string Comment { get; set; }

        public bool SetStatus(Status status)
        {
            switch (status)
            {
                case Status.Booked:
                    return false;
                case Status.InService:
                    if (Status == Status.Booked && !string.IsNullOrWhiteSpace(MechanicId))
                    {
                        Status = status;
                        return true;
                    }
                    return false;
                case Status.FixedCompleted:
                case Status.UnrepairableScrapped:
                    if (Status == Status.InService)
                    {
                        Status = status;
                        return true;
                    }
                    return false;
                case Status.Collected:
                    if (Status == Status.FixedCompleted || Status == Status.UnrepairableScrapped)
                    {
                        this.Status = status;
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }
    }
}