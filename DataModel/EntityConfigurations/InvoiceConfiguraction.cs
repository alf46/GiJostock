using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class InvoiceConfiguraction : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(invoice => invoice.Date).IsRequired();
            builder.Property(invoice => invoice.Reference).HasMaxLength(50);

            builder.Property(invoice => invoice.Observations).HasMaxLength(500);
            builder.Property(invoice => invoice.PaymentMethod).HasMaxLength(50);

            builder.Property(invoice => invoice.PaymentMethod).HasMaxLength(50);

            builder.Property(invoice => invoice.Date).HasDefaultValueSql("getdate()");

            builder.Ignore(x => x.Enable);
        }
    }
}