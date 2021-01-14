/// <summary>
/// 
/// </summary>
namespace FreedomMobileShop.Service.Interface
{
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.Entity.Entities;
    using System.Threading.Tasks;

    public interface IMobileStoreService
    {
        Task<ListResponse<Stock>> GetStocks();
    }
}