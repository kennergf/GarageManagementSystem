using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GarageManagementSystem.Models;

namespace GarageManagementSystem.ViewModels
{
    public class InvoiceViewModel
    {
        public string Id { get; set; }

        public string BookingId { get; set; }

        [Display(Name = "Customer")]
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Vehicle { get; set; }
        public string Licence { get; set; }

        public string Comment { get; set; }

    }
}