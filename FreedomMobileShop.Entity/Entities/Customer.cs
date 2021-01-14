namespace FreedomMobileShop.Entity.Entities
{
    using System.Collections.Generic;

    public class Customer
    {
        public Customer()
        {
            Customers = new HashSet<Customer>();
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}