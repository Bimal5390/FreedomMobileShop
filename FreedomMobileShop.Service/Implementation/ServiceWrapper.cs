/// <summary>
/// Wrapper class file for all services
/// </summary>
namespace FreedomMobileShop.Service.Implementation
{
    using FreedomMobileShop.DataAccess.Interface;
    using FreedomMobileShop.Service.Interface;
    using Microsoft.Extensions.Logging;
    public class ServiceWrapper : IServiceWrapper
    {
        #region Private Variables

        private IMobileStoreService _mobileStoreService;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private ILogger<MobileStoreService> _mobileStoreLogger;

        #endregion

        public ServiceWrapper(IRepositoryWrapper repositoryWrapper, ILogger<MobileStoreService> mobileStoreLogger)
        {
            _repositoryWrapper = repositoryWrapper;
            _mobileStoreLogger = mobileStoreLogger;
        }

        public IMobileStoreService MobileStoreService
        {
            get
            {
                if (_mobileStoreService == null)
                {
                    _mobileStoreService = new MobileStoreService(_repositoryWrapper, _mobileStoreLogger);
                }
                return _mobileStoreService;
            }
        }
    }
}