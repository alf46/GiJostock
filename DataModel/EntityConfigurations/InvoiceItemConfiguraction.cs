using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class InvoiceItemConfiguraction : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.HasKey(x => new { x.InvoiceID, x.ProductID });
        }
    }
}