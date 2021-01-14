/// <summary>
/// Class file contains all end points related to Mobile shop
/// </summary>
namespace FreedomMobileShop.Controllers
{
    using FreedomMobileShop.Service.Interface;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
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
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetStocks()
        {
            _logger.LogInformation("GetStocks end point processing started");
            return new ObjectResult(await _serviceWrapper.MobileStoreService.GetStocks());
        }
    }
}