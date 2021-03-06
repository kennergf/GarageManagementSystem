using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSystem.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }

        // Decimal(18.2)
        [RegularExpression(@"^(0|-?\d{0,18}(\.\d{0,2})?)$", ErrorMessage = "Invalid value!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }

        public bool Deleted { get; private set; }

        [StringLength(255, ErrorMessage = "The {0} can not exceed {1} characteres!")]
        public string Group { get; set; }

        public void MarkAsDeleted()
        {
            this.Deleted = true;
        }
    }
}