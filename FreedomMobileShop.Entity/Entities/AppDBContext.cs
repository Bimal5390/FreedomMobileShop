/// <summary>
/// 
/// </summary>
namespace FreedomMobileShop.Entity.Entities
{
    using Microsoft.EntityFrameworkCore;

    public partial class AppDBContext: DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("DbConnectionString"));
            }
        }
    }
}