/// <summary>
/// Base DB context file with SQL configuration details
/// </summary>
namespace FreedomMobileShop.Entity.Entities
{
    using Microsoft.EntityFrameworkCore;

    public partial class AppDBContext : DbContext
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
                optionsBuilder.UseSqlServer(@"Server=*****;DataBase=FreedomMobileShop;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mobile>(entity =>
            {
                entity.HasKey(e => e.MobileId)
                    .HasName("");

                entity.ToTable("Mobile", "public");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandID)
                    .HasName("");

                entity.ToTable("Brand", "public");
            });

            modelBuilder.Entity<Sell>(entity =>
            {
                entity.HasKey(e => e.SellId)
                    .HasName("");

                entity.ToTable("Sell", "public");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("");

                entity.ToTable("Customer", "public");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("");
                entity.HasKey(e => e.CustomerId)
                    .HasName("");
                entity.HasKey(e => e.MobileId)
                    .HasName("");

                entity.ToTable("Payment", "public");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("");

                entity.ToTable("Stock", "public");
            });
        }
    }
}