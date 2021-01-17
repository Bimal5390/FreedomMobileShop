/// <summary>
/// All Test cases for Mobile Store controller class
/// </summary>
namespace FreedomMobileShop.Test.Implementation
{
    using FreedomMobileShop.Controllers;
    using FreedomMobileShop.Service.Interface;
    using Microsoft.Extensions.Logging;
    using Moq;

    public class MobileStoreControllerTest
    {
        #region Private Variables

        private Mock<ILogger<MobileStoreController>> _mockLogger;
        private Mock<ILogger<IServiceWrapper>> _mockServiceWrapper;

        #endregion

        public MobileStoreControllerTest()
        {
            this._mockLogger = new Mock<ILogger<MobileStoreController>>();
            this._mockServiceWrapper = new Mock<ILogger<IServiceWrapper>>();
        }

        #region Test Methods

        #endregion
    }
}