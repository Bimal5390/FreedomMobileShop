/// <summary>
/// 
/// </summary>
namespace FreedomMobileShop.Service.Helper
{
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.Entity.Entities;
    using System.Net;

    public class Utility
    {
        public static ListResponse<Stock> SendErrorResponseGetStocks(string errorMessage)
        {
            ListResponse<Stock> response = new ListResponse<Stock>
            {
                Success = false,
                StatusCode = HttpStatusCode.BadRequest,
                Message = errorMessage,
                Response = null
            };
            return response;
        }

        public static ListResponse<Mobile> SendErrorResponseGetMobiles(string errorMessage)
        {
            ListResponse<Mobile> response = new ListResponse<Mobile>
            {
                Success = false,
                StatusCode = HttpStatusCode.BadRequest,
                Message = errorMessage,
                Response = null
            };
            return response;
        }

        public static ListResponse<Payment> SendErrorResponseGetPaymentReport(string errorMessage)
        {
            ListResponse<Payment> response = new ListResponse<Payment>
            {
                Success = false,
                StatusCode = HttpStatusCode.BadRequest,
                Message = errorMessage,
                Response = null
            };
            return response;
        }

        public static SingleResponse<bool> SendErrorResponseForMobile(string errorMessage)
        {
            SingleResponse<bool> response = new SingleResponse<bool>
            {
                Success = false,
                StatusCode = HttpStatusCode.BadRequest,
                Message = errorMessage,
                Response = false
            };
            return response;
        }
    }
}
