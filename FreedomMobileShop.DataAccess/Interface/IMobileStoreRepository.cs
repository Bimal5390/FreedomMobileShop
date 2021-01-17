/// <summary>
/// Interface for mobile store repository
/// </summary>
namespace FreedomMobileShop.DataAccess.Interface
{
    using FreedomMobileShop.Entity.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMobileStoreRepository
    {
        Task<IEnumerable<Stock>> GetAllStocks();
        Task<IEnumerable<Mobile>> GetAllMobiles();
        Task<IEnumerable<Mobile>> GetMobilesByModelName(string modelName);
        Task<IEnumerable<Payment>> GetSellsReportByDate(DateTime fromDate, DateTime toDate);
        Task<IEnumerable<Payment>> GetSellsReportByBrand(DateTime fromDate, DateTime toDate);
        Task<bool> DeleteMobileById(int mobileId);
        Task<bool> SaveMobile(Mobile mobile);
        Task<bool> UpdateMobileDetails(Mobile mobile);
        Task<IEnumerable<Brand>> GetAllBrands();
    }
}