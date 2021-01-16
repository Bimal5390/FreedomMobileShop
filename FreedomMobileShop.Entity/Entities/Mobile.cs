namespace FreedomMobileShop.Entity.Entities
{
    using System.Collections.Generic;

    public class Mobile
    {
        public Mobile()
        {
        }
        public int MobileId { get; set; }
        public string MobileCompanyId { get; set; }
        public string MobileModelId { get; set; }
        public string IMEINumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}