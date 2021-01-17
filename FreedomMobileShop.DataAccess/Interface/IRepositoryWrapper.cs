/// <summary>
/// Wrapper for all repositories
/// </summary>
namespace FreedomMobileShop.DataAccess.Interface
{
    public interface IRepositoryWrapper
    {
        IMobileStoreRepository MobileStoreRepository { get; }
    }
}