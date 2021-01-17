/// <summary>
/// Interface for mobile store service
/// </summary>
namespace FreedomMobileShop.Service.Interface
{
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.Entity.Entities;
    using System;
    using System.Threading.Tasks;

    public interface IMobileStoreService
    {
        Task<ListResponse<Stock>> GetAllStocks();
        Task<ListResponse<Mobile>> GetAllMobiles();
        Task<ListResponse<Mobile>> GetMobilesByModelName(string modelName);
        Task<ListResponse<Payment>> GetSellsReportByDate(DateTime fromDate, DateTime toDate);
        Task<ListResponse<Payment>> GetSellsReportByBrand(DateTime fromDate, DateTime toDate);
        Task<SingleResponse<bool>> DeleteMobileById(int mobileId);
        Task<SingleResponse<bool>> SaveMobile(Mobile mobile);
        Task<SingleResponse<bool>> UpdateMobileDetails(Mobile mobile);
    }
}