/// <summary>
/// Test class file for service layer
/// </summary>
namespace FreedomMobileShop.Service.Test.Implementation
{
    using FreedomMobileShop.Common.Constants;
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.DataAccess.Interface;
    using FreedomMobileShop.Entity.Entities;
    using FreedomMobileShop.Service.Helper;
    using FreedomMobileShop.Service.Implementation;
    using FreedomMobileShop.Service.Test.TestCaseData;
    using Microsoft.Extensions.Logging;
    using Moq;
    using Newtonsoft.Json;
    using Xunit;

    public class MobileStoreServiceTest
    {
        #region Private Variables

        private Mock<IRepositoryWrapper> _mockIServiceWrapper;
        private ServiceWrapper _serviceWrapper;
        private ILogger<MobileStoreService> _mobileStoreServiceLogger = Mock.Of<ILogger<MobileStoreService>>();

        #endregion

        public MobileStoreServiceTest()
        {
            _mockIServiceWrapper = new Mock<IRepositoryWrapper>();
            _serviceWrapper = new ServiceWrapper(_mockIServiceWrapper.Object, _mobileStoreServiceLogger);
        }

        #region TestMethods

        [Fact]
        public void GetAllBrands_With_Success_Response()
        {
            //Arrange
            ListResponse<Brand> expected = MobileStoreServiceTestData.GetAllBrandsSuccessResponse();

            _mockIServiceWrapper.Setup(m => m.MobileStoreRepository.GetAllBrands())
                               .Returns(MobileStoreServiceTestData.GetAllBrandDataAsync());

            // Act
            ListResponse<Brand> actual = _serviceWrapper.MobileStoreService.GetAllBrands().Result;

            // Asert
            Assert.NotNull(actual);
            Assert.Equal(actual.StatusCode, expected.StatusCode);
            Assert.Equal(actual.Success, expected.Success);
            Assert.Equal(JsonConvert.SerializeObject(actual.Response), JsonConvert.SerializeObject(expected.Response));
        }

        [Fact]
        public void GetAllBrands_With_Null_Response()
        {
            // Arrange
            ListResponse<Brand> expected = Utility.SendErrorResponseGetBrands(Constant.RECORD_NOT_FOUND);

            _mockIServiceWrapper.Setup(m => m.MobileStoreRepository.GetAllBrands())
                               .Returns(MobileStoreServiceTestData.HandleNullResponseForGetAllBrands());

            // Act
            ListResponse<Brand> actual = _serviceWrapper.MobileStoreService.GetAllBrands().Result;

            // Asert
            Assert.NotNull(actual);
            Assert.Equal(actual.StatusCode, expected.StatusCode);
            Assert.Equal(actual.Success, expected.Success);
            Assert.Equal(JsonConvert.SerializeObject(actual.Response), JsonConvert.SerializeObject(expected.Response));
        }

        [Fact]
        public void GetAllBrands_Handle_Exception()
        {
            // Arrange
            ListResponse<Brand> expected = Utility.SendErrorResponseGetBrands(Constant.ERROR_OCCURED);

            _mockIServiceWrapper.Setup(m => m.MobileStoreRepository.GetAllBrands())
                               .Returns(MobileStoreServiceTestData.HandleExceptionResponseForGetAllBrands());

            // Act
            ListResponse<Brand> actual = _serviceWrapper.MobileStoreService.GetAllBrands().Result;

            // Asert
            Assert.NotNull(actual);
            Assert.Equal(actual.StatusCode, expected.StatusCode);
            Assert.Equal(actual.Success, expected.Success);
            Assert.Equal(JsonConvert.SerializeObject(actual.Response), JsonConvert.SerializeObject(expected.Response));
        }

        [Fact]
        public void GetMobilesByModelName_With_Success_Response()
        {
            //Arrange
            string modelName = "ABD";
            ListResponse<Mobile> expected = MobileStoreServiceTestData.GetMobilesByModelNameWithSuccessResponse();

            _mockIServiceWrapper.Setup(m => m.MobileStoreRepository.GetMobilesByModelName(It.IsAny<string>()))
                               .Returns(MobileStoreServiceTestData.GetMobilesByModelNameAsync());

            // Act
            ListResponse<Mobile> actual = _serviceWrapper.MobileStoreService.GetMobilesByModelName(modelName).Result;

            // Asert
            Assert.NotNull(actual);
            Assert.Equal(actual.StatusCode, expected.StatusCode);
            Assert.Equal(actual.Success, expected.Success);
            Assert.Equal(JsonConvert.SerializeObject(actual.Response), JsonConvert.SerializeObject(expected.Response));
        }

        [Fact]
        public void GetMobilesByModelName_With_Null_Response()
        {
            // Arrange
            string modelName = "ABD";
            ListResponse<Mobile> expected = Utility.SendErrorResponseGetMobiles(Constant.RECORD_NOT_FOUND);

            _mockIServiceWrapper.Setup(m => m.MobileStoreRepository.GetMobilesByModelName(It.IsAny<string>()))
                               .Returns(MobileStoreServiceTestData.HandleNullResponseForGetMobilesByModelName());

            // Act
            ListResponse<Mobile> actual = _serviceWrapper.MobileStoreService.GetMobilesByModelName(modelName).Result;

            // Asert
            Assert.NotNull(actual);
            Assert.Equal(actual.StatusCode, expected.StatusCode);
            Assert.Equal(actual.Success, expected.Success);
            Assert.Equal(JsonConvert.SerializeObject(actual.Response), JsonConvert.SerializeObject(expected.Response));
        }

        [Fact]
        public void GetMobilesByModelName_Handle_Exception()
        {
            // Arrange
            string modelName = "ABD";
            ListResponse<Mobile> expected = Utility.SendErrorResponseGetMobiles(Constant.ERROR_OCCURED);

            _mockIServiceWrapper.Setup(m => m.MobileStoreRepository.GetMobilesByModelName(It.IsAny<string>()))
                               .Returns(MobileStoreServiceTestData.HandleExceptionResponseForGetMobilesByModelName());

            // Act
            ListResponse<Mobile> actual = _serviceWrapper.MobileStoreService.GetMobilesByModelName(modelName).Result;

            // Asert
            Assert.NotNull(actual);
            Assert.Equal(actual.StatusCode, expected.StatusCode);
            Assert.Equal(actual.Success, expected.Success);
            Assert.Equal(JsonConvert.SerializeObject(actual.Response), JsonConvert.SerializeObject(expected.Response));
        }

        /* Like above we can write the test cases for GetAllStocks, GetAllMobiles */

        #endregion
    }
}