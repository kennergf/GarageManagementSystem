using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSystem.Models
{
    // REF http://jameschambers.com/2019/06/No-Type-Was-Specified-for-the-Decimal-Column/
    public class InvoiceService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [ForeignKey("Invoice")]
        public string InvoiceId { get; set; }

        public string Name { get; set; }

        // Decimal(18.2)
        [RegularExpression(@"^(0|-?\d{0,18}(\.\d{0,2})?)$", ErrorMessage = "Invalid value!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }

        [Range(1, 99, ErrorMessage = "Quantity must be between 1 and 99")]
        public int Quantity { get; set; }
    }
}