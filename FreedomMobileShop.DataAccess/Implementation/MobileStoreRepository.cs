/// <summary>
/// 
/// </summary>
namespace FreedomMobileShop.DataAccess.Implementation
{
    using FreedomMobileShop.DataAccess.Interface;
    using FreedomMobileShop.Entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MobileStoreRepository: BaseRepository, IMobileStoreRepository
    {
        public MobileStoreRepository()
        {
        }

        public async Task<IEnumerable<Stock>> GetStocks()
        {
            try
            {
                return await this.Context.Stock.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}