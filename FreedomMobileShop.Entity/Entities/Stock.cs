namespace FreedomMobileShop.Entity.Entities
{
    using System.Collections.Generic;

    public class Stock
    {
        public Stock()
        {
            Stocks = new HashSet<Stock>();
        }
        public int StockId { get; set; }
        public string Items { get; set; }
        public long Number { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}