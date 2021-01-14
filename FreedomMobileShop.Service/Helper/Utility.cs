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
    }
}
