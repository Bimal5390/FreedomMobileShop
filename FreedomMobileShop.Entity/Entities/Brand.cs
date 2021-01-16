namespace FreedomMobileShop.Entity.Entities
{
    using System.Collections.Generic;

    public class Brand
    {
        public Brand()
        {
        }
        public int BrandID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}