/// <summary>
/// 
/// </summary>
namespace FreedomMobileShop.DataAccess.Implementation
{
    using FreedomMobileShop.DataAccess.Interface;
    using FreedomMobileShop.Entity.Entities;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using System;

    public class BaseRepository : IDisposable, IRepositoryWrapper
    {
        protected static AppDBContext _context;
        private readonly IConfiguration _config;
        private IMobileStoreRepository _mobileStoreRepository;
        protected static string _connectionString;

        public BaseRepository(IConfiguration config)
        {
            _config = config;
            GetOpenConnection(config);
        }

        public SqlConnection GetOpenConnection(IConfiguration config)
        {
            _connectionString = config["ConnectionStrings:FreedomMobileShopDB"];
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public BaseRepository()
        {
        }

        public IMobileStoreRepository MobileStoreRepository
        {
            get
            {
                if (_mobileStoreRepository == null)
                {
                    _mobileStoreRepository = new MobileStoreRepository();
                }
                return _mobileStoreRepository;
            }
        }

        protected AppDBContext Context
        {
            get
            {
                if (_context == null || _context.Model == null)
                {
                    _context = CreateConnection();
                }
                return _context;
            }
        }

        protected AppDBContext CreateConnection()
        {
            DbContextOptionsBuilder<AppDBContext> optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
            optionsBuilder.UseSqlServer(_connectionString);
            _context = new AppDBContext(optionsBuilder.Options);
            return _context;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();  
        }
    }
}