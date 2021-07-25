using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using GarageManagementSystem.Data;
using GarageManagementSystem.Enums;
using GarageManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GarageManagementSystem.ViewModels
{
    public class BookingViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Customer")]
        public string CustomerId { get; set; }

        [Display(Name = "Vehicle")]
        public string VehicleId { get; set; }

        [Display(Name = "Booking Type")]
        public BookingType BookingType { get; set; }

        [Display(Name = "Date of Booking")]
        public DateTime Date { get; set; }

        public Status Status { get; set; }

        public string Comment { get; set; }

        public List<SelectListItem> Vehicles { get; set; }
        public List<SelectListItem> AvailableDates { get; set; }

        public void SetVehicles(List<Vehicle> vehicles)
        {
            this.Vehicles = vehicles.Select(v => new SelectListItem
            {
                Value = v.Id,
                Text = v.Licence,
            }).ToList();
        }

        public void SetAvailableDates(List<DateTime> availableDates)
        {
            this.AvailableDates = availableDates.Select(d => new SelectListItem
            {
                Value = d.ToString(),
                Text = d.ToString(),
            }).ToList();
        }
    }
}