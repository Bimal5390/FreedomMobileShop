/// <summary>
/// Generic class for all types(Single/List) of response
/// </summary>
namespace FreedomMobileShop.Common.Helpers
{
    using FreedomMobileShop.Common.Constants;
    using System.Collections.Generic;
    using System.Net;

    public class ServiceResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public bool Success { get; set; } = true;
        public string Message { get; set; } = Constant.RECORD_FOUND;
        public T Response { get; set; } = default(T);
    }

    public interface IResponse
    {
        string Message { get; set; }
        bool Success { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }

    public interface IListResponse<TModel> : IResponse
    {
        IEnumerable<TModel> Response { get; set; }
    }

    public interface ISingleResponse<TModel> : IResponse
    {
        TModel Response { get; set; }
    }

    public class SingleResponse<TModel> : ISingleResponse<TModel>
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public bool Success { get; set; } = true;
        public string Message { get; set; } = Constant.RECORD_FOUND;
        public TModel Response { get; set; }
    }

    public class ListResponse<TModel> : IListResponse<TModel>
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public bool Success { get; set; } = true;
        public string Message { get; set; } = Constant.RECORD_FOUND;
        public IEnumerable<TModel> Response { get; set; }
    }
}