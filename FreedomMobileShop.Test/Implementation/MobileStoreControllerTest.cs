/// <summary>
/// All Test cases for Mobile Store controller class
/// </summary>
namespace FreedomMobileShop.Test.Implementation
{
    using FreedomMobileShop.Controllers;
    using FreedomMobileShop.Service.Implementation;
    using FreedomMobileShop.Service.Interface;
    using Microsoft.Extensions.Logging;
    using Moq;

    public class MobileStoreControllerTest
    {
        #region Private Variables

        private Mock<ILogger<MobileStoreController>> _mockLogger;
        private Mock<IServiceWrapper> _mockServiceWrapper;
        private ServiceWrapper _serviceWrapper;

        #endregion

        public MobileStoreControllerTest()
        {
            _mockServiceWrapper = new Mock<IServiceWrapper>();
            this._mockLogger = new Mock<ILogger<MobileStoreController>>();
        }

        #region Test Methods

        /*Like Service layer we can add the test cased for controller class as well*/

        #endregion
    }
}