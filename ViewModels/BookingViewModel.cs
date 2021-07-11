using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GarageManagementSystem.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GarageManagementSystem.ViewModels
{
    public class BookingViewModel
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }

        [Display(Name = "Vehicle")]
        public string VehicleId { get; set; }

        [Display(Name = "Booking Type")]
        public BookingType BookingType { get; set; }

        [Display(Name = "Date of Booking")]
        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public List<SelectListItem> Vehicles { get; set; }
        public List<SelectListItem> AvailableDates { get; set; }
    }
}