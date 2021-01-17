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

    public class MobileStoreService : IMobileStoreService
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

        /// <summary>
        /// Business logic for getting stocks available
        /// </summary>
        /// <returns>List of stocks</returns>
        public async Task<ListResponse<Stock>> GetAllStocks()
        {
            ListResponse<Stock> result = new ListResponse<Stock>();
            try
            {
                IEnumerable<Stock> data = await _repositoryWrapper.MobileStoreRepository.GetAllStocks();
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

        /// <summary>
        /// Business logic for getting all mobile details
        /// </summary>
        /// <returns>List of mobiles</returns>
        public async Task<ListResponse<Mobile>> GetAllMobiles()
        {
            ListResponse<Mobile> result = new ListResponse<Mobile>();
            try
            {
                IEnumerable<Mobile> data = await _repositoryWrapper.MobileStoreRepository.GetAllMobiles();
                if (data != null && data.Count() > 0)
                {
                    _logger.LogInformation("Data available for given input");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data is not present for the given input");
                    return Utility.SendErrorResponseGetMobiles(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseGetMobiles(Constant.ERROR_OCCURED);
            }
        }

        /// <summary>
        /// Business logic for getting mobile details by name
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns>Return mobile details</returns>
        public async Task<ListResponse<Mobile>> GetMobilesByModelName(string modelName)
        {
            ListResponse<Mobile> result = new ListResponse<Mobile>();
            try
            {
                if (string.IsNullOrEmpty(modelName))
                {
                    _logger.LogInformation("Invalid Input");
                    return Utility.SendErrorResponseGetMobiles(Constant.INVALID_INPUT);
                }
                IEnumerable<Mobile> data = await _repositoryWrapper.MobileStoreRepository.GetMobilesByModelName(modelName);
                if (data != null && data.Count() > 0)
                {
                    _logger.LogInformation("Data available for given input");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data is not present for the given input");
                    return Utility.SendErrorResponseGetMobiles(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseGetMobiles(Constant.ERROR_OCCURED);
            }
        }

        /// <summary>
        /// Business logic for fetching sells report by date
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns>Returns sells list</returns>
        public async Task<ListResponse<Payment>> GetSellsReportByDate(DateTime fromDate, DateTime toDate)
        {
            ListResponse<Payment> result = new ListResponse<Payment>();
            try
            {
                IEnumerable<Payment> data = await _repositoryWrapper.MobileStoreRepository.GetSellsReportByDate(fromDate, toDate);
                if (data != null && data.Count() > 0)
                {
                    _logger.LogInformation("Data available for given input");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data is not present for the given input");
                    return Utility.SendErrorResponseGetPaymentReport(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseGetPaymentReport(Constant.ERROR_OCCURED);
            }
        }

        /// <summary>
        /// Business logic for fetching sells report by brand name and date
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns>Returns sells list</returns>
        public async Task<ListResponse<Payment>> GetSellsReportByBrand(DateTime fromDate, DateTime toDate)
        {
            ListResponse<Payment> result = new ListResponse<Payment>();
            try
            {
                IEnumerable<Payment> data = await _repositoryWrapper.MobileStoreRepository.GetSellsReportByBrand(fromDate, toDate);
                if (data != null && data.Count() > 0)
                {
                    _logger.LogInformation("Data available for given input");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data is not present for the given input");
                    return Utility.SendErrorResponseGetPaymentReport(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseGetPaymentReport(Constant.ERROR_OCCURED);
            }
        }

        /// <summary>
        /// Business logic for deleting the mobile details by id
        /// </summary>
        /// <param name="mobileId"></param>
        /// <returns>true if success false if fails</returns>
        public async Task<SingleResponse<bool>> DeleteMobileById(int mobileId)
        {
            SingleResponse<bool> result = new SingleResponse<bool>();
            try
            {
                if (mobileId <= 0)
                {
                    _logger.LogInformation("Invalid Input");
                    return Utility.SendErrorResponseForMobile(Constant.INVALID_INPUT);
                }
                bool data = await _repositoryWrapper.MobileStoreRepository.DeleteMobileById(mobileId);
                if (data != null)
                {
                    _logger.LogInformation("Data deleted");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data is not present for the given input");
                    return Utility.SendErrorResponseForMobile(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseForMobile(Constant.ERROR_OCCURED);
            }
        }

        /// <summary>
        /// Business logic for saving the mobile details
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns>true if success false if fails</returns>
        public async Task<SingleResponse<bool>> SaveMobile(Mobile mobile)
        {
            SingleResponse<bool> result = new SingleResponse<bool>();
            try
            {
                if (mobile == null)
                {
                    _logger.LogInformation("Invalid Input");
                    return Utility.SendErrorResponseForMobile(Constant.INVALID_INPUT);
                }
                bool data = await _repositoryWrapper.MobileStoreRepository.SaveMobile(mobile);
                if (data != null)
                {
                    _logger.LogInformation("Data saved");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data not saved");
                    return Utility.SendErrorResponseForMobile(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseForMobile(Constant.ERROR_OCCURED);
            }
        }

        /// <summary>
        /// Business logic for updating the mobile details
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns>true if success false if fails</returns>
        public async Task<SingleResponse<bool>> UpdateMobileDetails(Mobile mobile)
        {
            SingleResponse<bool> result = new SingleResponse<bool>();
            try
            {
                if (mobile == null)
                {
                    _logger.LogInformation("Invalid Input");
                    return Utility.SendErrorResponseForMobile(Constant.INVALID_INPUT);
                }
                bool data = await _repositoryWrapper.MobileStoreRepository.UpdateMobileDetails(mobile);
                if (data != null)
                {
                    _logger.LogInformation("Data saved");
                    result.Response = data;
                }
                else
                {
                    _logger.LogWarning("Data not saved");
                    return Utility.SendErrorResponseForMobile(Constant.RECORD_NOT_FOUND);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurs: " + ex.Message);
                return Utility.SendErrorResponseForMobile(Constant.ERROR_OCCURED);
            }
        }
    }
}