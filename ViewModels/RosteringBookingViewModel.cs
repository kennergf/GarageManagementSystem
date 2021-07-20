using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using GarageManagementSystem.Enums;
using GarageManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GarageManagementSystem.ViewModels
{
    public class RosteringBookingViewModel : BookingViewModel
    {
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Vehicle")]
        public string VehicleLicence { get; set; }

        [Display(Name = "Mechanic")]
        public string MechanicId { get; set; }

        [Display(Name = "Mechanic")]
        public string MechanicName { get; set; }

        public List<SelectListItem> Mechanics { get; set; }

        public void SetMechanics(List<ApplicationUser> mechanics)
        {
            this.Mechanics = mechanics.Select(m => new SelectListItem
            {
                Value = m.Id,
                Text = m.UserName,
            }).ToList();
        }
    }
}