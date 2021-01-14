namespace FreedomMobileShop.Entity.Entities
{
    using System;
    using System.Collections.Generic;

    public class Payment
    {
        public Payment()
        {
            Payments = new HashSet<Payment>();
        }
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public int MobileId { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}