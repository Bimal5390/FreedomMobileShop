﻿namespace FreedomMobileShop.Entity.Entities
{
    using System;

    public class Payment
    {
        public Payment()
        {
        }
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public int MobileId { get; set; }
        public int BrandId { get; set; }
    }
}