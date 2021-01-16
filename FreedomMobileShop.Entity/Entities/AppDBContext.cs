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
                entity.HasKey(e => e.MobileId).HasName("MobileId");
                entity.HasKey(e => e.Description)
                    .HasName("Description");
                entity.HasKey(e => e.IMEINumber)
                    .HasName("IMEINumber");
                entity.HasKey(e => e.MobileCompanyId)
                    .HasName("MobileCompanyId");
                entity.HasKey(e => e.MobileModelId)
                    .HasName("MobileModelId");
                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .IsUnicode(false);

                entity.HasKey(e => e.Type)
                    .HasName("Type");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandID)
                    .HasName("BrandID");
                entity.HasKey(e => e.Company)
                    .HasName("Company");
                entity.HasKey(e => e.Description)
                    .HasName("Description");
                entity.HasKey(e => e.Name)
                    .HasName("Name");
                entity.HasKey(e => e.Type)
                    .HasName("Type");
            });

            modelBuilder.Entity<Sell>(entity =>
            {
                entity.HasKey(e => e.SellId)
                    .HasName("SellId");
                entity.HasKey(e => e.Description)
                    .HasName("Description");
                entity.HasKey(e => e.Name)
                    .HasName("Name");
                entity.HasKey(e => e.Type)
                    .HasName("Type");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("CustomerId");
                entity.HasKey(e => e.Name)
                    .HasName("Name");
                entity.HasKey(e => e.MobileNumber)
                    .HasName("MobileNumber");
                entity.HasKey(e => e.Email)
                    .HasName("Email");
                entity.HasKey(e => e.AddressLine1)
                    .HasName("AddressLine1");
                entity.HasKey(e => e.AddressLine2)
                    .HasName("AddressLine2");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PaymentId");
                entity.HasKey(e => e.CustomerId)
                    .HasName("CustomerId");
                entity.HasKey(e => e.MobileId)
                    .HasName("MobileId");
                entity.HasKey(e => e.Amount)
                    .HasName("Amount");
                entity.HasKey(e => e.Description)
                    .HasName("Description");
                entity.HasKey(e => e.PaymentDate)
                    .HasName("PaymentDate");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("StockId");
                entity.HasKey(e => e.Description)
                    .HasName("Description");
                entity.HasKey(e => e.Items)
                    .HasName("Items");
                entity.HasKey(e => e.Number)
                    .HasName("Number");
                entity.HasKey(e => e.Type)
                    .HasName("Type");
            });
        }

        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Mobile> Mobile { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Sell> Sell { get; set; }
    }
}