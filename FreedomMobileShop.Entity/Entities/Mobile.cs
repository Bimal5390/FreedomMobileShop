namespace FreedomMobileShop.Entity.Entities
{
    public class Mobile
    {
        public int MobileId { get; set; }
        public long MobileCompanyId { get; set; }
        public int MobileModelId { get; set; }
        public string IMEINumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}