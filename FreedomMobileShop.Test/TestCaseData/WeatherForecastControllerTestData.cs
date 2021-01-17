namespace FreedomMobileShop.Test.TestCaseData
{
    using FreedomMobileShop.Common.Constants;
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.Entity.Entities;
    using System;
    using System.Collections.Generic;
    using System.Net;

    public class WeatherForecastControllerTestData
    {
        internal static ListResponse<WeatherForecast> GetWeatherForecastDetails()
        {
            return new ListResponse<WeatherForecast>
            {
                Response = new List<WeatherForecast>
                {
                    new WeatherForecast
                    {
                        Date = Convert.ToDateTime("2021-01-17T20:07:24.9148722+05:30"),
                        TemperatureC= -2,
                        Summary = "Balmy"
                    },
                    new WeatherForecast
                    {
                        Date = Convert.ToDateTime("2021-01-18T20:07:24.9153476+05:30"),
                        TemperatureC= 16,
                        Summary = "Cool"
                    },
                    new WeatherForecast
                    {
                        Date = Convert.ToDateTime("2021-01-19T20:07:24.9153521+05:30"),
                        TemperatureC= 36,
                        Summary = "Balmy"
                    },
                    new WeatherForecast
                    {
                        Date = Convert.ToDateTime("2021-01-20T20:07:24.9153527+05:30"),
                        TemperatureC= 36,
                        Summary = "Bracing"
                    },
                    new WeatherForecast
                    {
                        Date = Convert.ToDateTime("2021-01-21T20:07:24.9153531+05:30"),
                        TemperatureC= 2,
                        Summary = "Cool"
                    }
                },
                Message = Constant.RECORD_FOUND,
                StatusCode = HttpStatusCode.OK,
                Success = true
            };
        }
    }
}
