using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class ProductConfiguraction : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(category => category.Name).HasMaxLength(300).IsRequired();
            builder.HasIndex(category => category.Name).IsUnique();

            builder.Property(category => category.Description).HasMaxLength(2000);
            builder.Property(category => category.QuantityPerUnit).HasMaxLength(50);
            builder.Property(category => category.Barcode).HasMaxLength(100);

            builder.Property(category => category.CreateDate).HasDefaultValueSql("getdate()");
        }
    }
}