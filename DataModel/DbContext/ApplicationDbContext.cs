using DataModel.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DataModel.StockDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductWarehouse> ProductWarehouses { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<EntryItem> EntryItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguraction());
            modelBuilder.ApplyConfiguration(new UserConfiguraction());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguraction());
            modelBuilder.ApplyConfiguration(new SupplierConfiguraction());

            modelBuilder.ApplyConfiguration(new ProductConfiguraction());
            modelBuilder.ApplyConfiguration(new ProductWarehouseConfiguraction());

            modelBuilder.ApplyConfiguration(new EntryConfiguraction());
            modelBuilder.ApplyConfiguration(new EntryItemConfiguraction());

            modelBuilder.ApplyConfiguration(new InvoiceConfiguraction());
            modelBuilder.ApplyConfiguration(new InvoiceItemConfiguraction());
        }
    }
}