/// <summary>
/// Class file contains all end points related to Mobile shop
/// </summary>
namespace FreedomMobileShop.Controllers
{
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.Entity.Entities;
    using FreedomMobileShop.Service.Interface;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class MobileStoreController : ControllerBase
    {
        #region Private Variables

        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILogger _logger;

        #endregion

        public MobileStoreController(IServiceWrapper serviceWrapper, ILogger<MobileStoreController> logger)
        {
            _serviceWrapper = serviceWrapper;
            _logger = logger;
        }

        /// <summary>
        /// End point to get the stocks available
        /// </summary>
        /// <returns>Return all stocks</returns>
        [HttpGet]
        [Route("GetStocks")]
        public async Task<IActionResult> GetAllStocks()
        {
            _logger.LogInformation("GetAllStocks end point processing started");
            ListResponse<Stock> data = await _serviceWrapper.MobileStoreService.GetAllStocks();
            return new ObjectResult(data);
        }

        /// <summary>
        /// End Point to get the list of mobile available in the shop
        /// </summary>
        /// <returns>Returns all mobiles</returns>
        [HttpGet]
        [Route("GetMobiles")]
        public async Task<IActionResult> GetAllMobiles()
        {
            _logger.LogInformation("GetAllMobiles end point processing started");
            ListResponse<Mobile> data = await _serviceWrapper.MobileStoreService.GetAllMobiles();
            return new ObjectResult(data);
        }

        /// <summary>
        /// Fetch list of mobiles with same model name
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns>Returns mobile with same model name</returns>
        [HttpGet]
        [Route("GetMobilesByModelName")]
        public async Task<IActionResult> GetMobilesByModelName(string modelName)
        {
            _logger.LogInformation("GetMobilesByModelName end point processing started");
            ListResponse<Mobile> data = await _serviceWrapper.MobileStoreService.GetMobilesByModelName(modelName);
            return new ObjectResult(data);
        }

        /// <summary>
        /// End point to fetch the sells report for within given dates
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns>Returns list of sells reports</returns>
        [HttpGet]
        [Route("GetSellsReportByDate")]
        public async Task<IActionResult> GetSellsReportByDate(DateTime fromDate, DateTime toDate)
        {
            _logger.LogInformation("GetSellsReportByDate end point processing started");
            ListResponse<Payment> data = await _serviceWrapper.MobileStoreService.GetSellsReportByDate(fromDate, toDate);
            return new ObjectResult(data);
        }

        /// <summary>
        /// Fetch the sells report within given date by brand wise
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns>Fetch list of sells report</returns>
        [HttpGet]
        [Route("GetSellsReportByBrand")]
        public async Task<IActionResult> GetSellsReportByBrand(DateTime fromDate, DateTime toDate)
        {
            _logger.LogInformation("GetSellsReportByBrand end point processing started");
            ListResponse<Payment> data = await _serviceWrapper.MobileStoreService.GetSellsReportByBrand(fromDate, toDate);
            return new ObjectResult(data);
        }

        /// <summary>
        /// End point to delete a existing mobile by id
        /// </summary>
        /// <param name="mobileId"></param>
        /// <returns>true is success and false if fails</returns>
        [HttpDelete]
        [Route("DeleteMobileById")]
        public async Task<IActionResult> DeleteMobileById(int mobileId)
        {
            _logger.LogInformation("DeleteMobileById end point processing started");
            SingleResponse<bool> data = await _serviceWrapper.MobileStoreService.DeleteMobileById(mobileId);
            return new ObjectResult(data);
        }

        /// <summary>
        /// End point for inserting a new mobile
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns>true if success and false if fails</returns>
        [HttpPost]
        [Route("SaveMobile")]
        public async Task<IActionResult> SaveMobile([FromBody]Mobile mobile)
        {
            _logger.LogInformation("SaveMobile end point processing started");
            SingleResponse<bool> data = await _serviceWrapper.MobileStoreService.SaveMobile(mobile);
            return new ObjectResult(data);
        }

        /// <summary>
        /// End point for updating mobile details
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns>true if success and false if fails</returns>
        [HttpPut]
        [Route("UpdateMobile")]
        public async Task<IActionResult> UpdateMobileDetails([FromBody] Mobile mobile)
        {
            _logger.LogInformation("UpdateMobile end point processing started");
            SingleResponse<bool> data = await _serviceWrapper.MobileStoreService.UpdateMobileDetails(mobile);
            return new ObjectResult(data);
        }
    }
}