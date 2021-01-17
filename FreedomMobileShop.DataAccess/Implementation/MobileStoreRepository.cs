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
    using System.Linq;
    using System.Threading.Tasks;

    public class MobileStoreRepository : BaseRepository, IMobileStoreRepository
    {
        public MobileStoreRepository()
        {
        }

        public async Task<IEnumerable<Stock>> GetAllStocks()
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

        public async Task<IEnumerable<Mobile>> GetAllMobiles()
        {
            try
            {
                return await this.Context.Mobile.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Mobile>> GetMobilesByModelName(string modelName)
        {
            try
            {
                return await this.Context.Mobile.Where(c => c.Name == modelName).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Payment>> GetSellsReportByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return await this.Context.Payment.Where(c => c.PaymentDate >= fromDate && c.PaymentDate <= toDate).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Payment>> GetSellsReportByBrand(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return await this.Context.Payment.Where(c => c.PaymentDate >= fromDate && c.PaymentDate <= toDate).OrderBy(c => c.BrandId).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteMobileById(int mobileId)
        {
            try
            {
                using (var ctx = new AppDBContext())
                {
                    var x = new Mobile { MobileId = mobileId };
                    ctx.Entry(x).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> SaveMobile(Mobile mobile)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    var mbl = new Mobile()
                    {
                        MobileCompanyId = mobile.MobileCompanyId,
                        MobileModelId = mobile.MobileModelId,
                        Description = mobile.Description,
                        IMEINumber = mobile.IMEINumber,
                        Name = mobile.Name,
                        Type = mobile.Type
                    };
                    context.Mobile.Add(mbl);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateMobileDetails(Mobile mobile)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    var mbl = context.Mobile.First<Mobile>();
                    mbl.Description = mobile.Description;
                    mbl.Type = mobile.Type;
                    mbl.Name = mobile.Name;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}