using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSystem.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [ForeignKey("Booking")]
        public string BookingId { get; set; }

        public Booking Booking { get; set; }

        [Display(Name = "Customer")]
        public string CustomerName { get; set; }

        public string Phone { get; set; }

        public string Vehicle { get; set; }

        public string Licence { get; set; }

        public string Comment { get; set; }

        public ICollection<InvoiceService> InvoiceServices { get; set; }
    }
}