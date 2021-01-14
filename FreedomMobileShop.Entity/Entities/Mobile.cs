namespace FreedomMobileShop.Entity.Entities
{
    using System.Collections.Generic;

    public class Mobile
    {
        public Mobile()
        {
            Mobiles = new HashSet<Mobile>();
        }
        public int MobileId { get; set; }
        public string MobileCompanyId { get; set; }
        public string MobileModelId { get; set; }
        public string IMEINumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Mobile> Mobiles { get; set; }
    }
}