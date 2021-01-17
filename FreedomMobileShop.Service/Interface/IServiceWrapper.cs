/// <summary>
/// Wrapper for service interface
/// </summary>
namespace FreedomMobileShop.Service.Interface
{
    public interface IServiceWrapper
    {
        IMobileStoreService MobileStoreService { get; }
    }
}