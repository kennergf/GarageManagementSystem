using System.ComponentModel.DataAnnotations;

namespace GarageManagementSystem.ViewModels
{
    // REF https://www.c-sharpcorner.com/blogs/range-data-annotation-attribute-in-mvc1
    public class InvoiceServiceViewModel
    {
        public string Id { get; set; }

        [Required]
        public string InvoiceId { get; set; }

        [Required]
        [Display(Name = "Service")]
        public string ServiceId { get; set; }

        [Range(1, 99, ErrorMessage = "Quantity must be between 1 and 99")]
        public int Quantity { get; set; }
    }
}