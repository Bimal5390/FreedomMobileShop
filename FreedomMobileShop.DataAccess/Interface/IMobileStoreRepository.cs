/// <summary>
/// 
/// </summary>
namespace FreedomMobileShop.DataAccess.Interface
{
    using FreedomMobileShop.Entity.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMobileStoreRepository
    {
        Task<IEnumerable<Stock>> GetStocks();
    }
}