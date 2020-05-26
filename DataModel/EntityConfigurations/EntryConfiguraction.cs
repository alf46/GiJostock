using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class EntryConfiguraction : IEntityTypeConfiguration<Entry>
    {
        public void Configure(EntityTypeBuilder<Entry> builder)
        {
            builder.Property(entry => entry.Comment).HasMaxLength(200);
            builder.Property(entry => entry.Reference).HasMaxLength(50);

            builder.Property(entry => entry.Date).HasDefaultValueSql("getdate()");
        }
    }
}