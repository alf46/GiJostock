using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class ProductWarehouseConfiguraction : IEntityTypeConfiguration<ProductWarehouse>
    {
        public void Configure(EntityTypeBuilder<ProductWarehouse> builder)
        {
            builder.HasKey(e => new { e.ProductID, e.WarehouseID });
        }
    }
}