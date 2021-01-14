namespace FreedomMobileShop.Entity.Entities
{
    using System.Collections.Generic;

    public class Sell
    {
        public Sell()
        {
            Sells = new HashSet<Sell>();
        }
        public int SellId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
    }
}