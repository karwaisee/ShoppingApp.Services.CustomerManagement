using System;

namespace ShoppingApp.Services.CustomerManagement.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public CustomerStatus Status { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal CreditOwe { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public int Postcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public enum CustomerStatus { Good = 1, InDebt = 2 };
}
