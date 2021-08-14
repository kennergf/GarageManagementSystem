using System.Collections.Generic;
using System.Linq;
using GarageManagementSystem.Models;

namespace GarageManagementSystem.ViewModels
{
    public class PrintInvoiceViewModel : InvoiceViewModel
    {
        public ICollection<InvoiceService> InvoiceServices { get; set; }

        public ICollection<InvoicePart> InvoiceParts { get; set; }

        public decimal TotalServices()
        {
            return InvoiceServices.Select(ise => ise.Quantity * ise.Value).Sum();
        }

        public decimal TotalParts()
        {
            return InvoiceParts.Select(ise => ise.Quantity * ise.Value).Sum();
        }

        public decimal TotalDue()
        {
            return TotalServices() + TotalParts();
        }
    }
}