using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class SupplierConfiguraction : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(supplier => supplier.Name).HasMaxLength(100).IsRequired();
            builder.HasIndex(supplier => supplier.Name).IsUnique();

            builder.Property(supplier => supplier.Document).HasMaxLength(30).IsRequired();

            builder.Property(supplier => supplier.Address).HasMaxLength(500).IsRequired();
            builder.Property(supplier => supplier.Phone).HasMaxLength(11).IsRequired();
            builder.Property(supplier => supplier.Email).HasMaxLength(200);
        }
    }
}