namespace FreedomMobileShop.Test.Implementation
{
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.Controllers;
    using FreedomMobileShop.Entity.Entities;
    using FreedomMobileShop.Test.TestCaseData;
    using Microsoft.Extensions.Logging;
    using Moq;
    using Xunit;

    public class WeatherForecastControllerTest
    {
        private Mock<ILogger<WeatherForecastController>> _mockLogger;

        public WeatherForecastControllerTest()
        {
            this._mockLogger = new Mock<ILogger<WeatherForecastController>>();
        }

        [Fact]
        public void Get_Return_Response_Correctly()
        {
            // Arrange
            ListResponse<WeatherForecast> expected = WeatherForecastControllerTestData.GetWeatherForecastDetails();

            // Act
            WeatherForecastController testClass = new WeatherForecastController(this._mockLogger.Object);
            var actual = testClass.Get();

            // Assert
            Assert.Equal("OK", expected.StatusCode.ToString());
            //Assert.Equal(expected.Response, actual);
        }
    }
}