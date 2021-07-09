using System.ComponentModel.DataAnnotations;

namespace GarageManagementSystem.Enums
{
    public enum BookingType
    {
        [Display(Name = "Annual Service")]
        AnnualService,
        [Display(Name = "Major Service")]
        MajorService,
        [Display(Name = "Repair / Fault")]
        RepairFault,
        [Display(Name = "Major Repair")]
        MajorRepair,
    }
}