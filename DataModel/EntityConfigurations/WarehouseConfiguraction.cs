using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class WarehouseConfiguraction : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.Property(category => category.Name).HasMaxLength(100).IsRequired();
            builder.HasIndex(category => category.Name).IsUnique();

            builder.Property(user => user.Address).HasMaxLength(500).IsRequired();
        }
    }
}