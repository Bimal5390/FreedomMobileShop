/// <summary>
/// 
/// </summary>
namespace FreedomMobileShop.Service.Implementation
{
    using FreedomMobileShop.Common.Constants;
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.DataAccess.Interface;
    using FreedomMobileShop.Entity.Entities;
    using FreedomMobileShop.Service.Helper;
    using FreedomMobileShop.Service.Interface;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MobileStoreService: IMobileStoreService
    {
        #region Private Variables

        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly ILogger _logger;

        #endregion

        public MobileStoreService(IRepositoryWrapper repositoryWrapper, ILogger<MobileStoreService> logger)
        {
            _repositoryWrapper = repositoryWrapper;
            _logger = logger;
        }

        public async Task<ListResponse<Stock>> GetStocks()
        {
            ListResponse<Stock> result = new ListResponse<Stock>();
            try
            {
                IEnumerable<Stock> data = await _repositoryWrapper.MobileStoreRepository.GetStocks();
                if (data != null && data.Count() > 0)
                {
                    _logger.LogInformation("Data available for given input");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data is not present for the given input");
                    return Utility.SendErrorResponseGetStocks(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseGetStocks(Constant.ERROR_OCCURED);
            }
        }
    }
}