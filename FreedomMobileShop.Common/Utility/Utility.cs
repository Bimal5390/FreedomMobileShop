using FreedomMobileShop.Common.Helpers;
using System.Net;

namespace FreedomMobileShop.Common.Utility
{
    public class Utility
    {
        public static dynamic SendErrorResponse(string errorMessage)
        {
            ServiceResponse<dynamic> response = new ServiceResponse<dynamic>
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