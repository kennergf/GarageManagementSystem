using System.Collections.Generic;

namespace GarageManagementSystem.Models
{
    public class Invoice
    {
        public string Id { get; set; }
        public string Customer {get;set;}
        public string Phone {get;set;}
        public string Vehicle {get;set;}
        public string Licence {get;set;}
        public List<Service> Services {get;set;}
        public List<Part> Parts {get;set;}
    }
}