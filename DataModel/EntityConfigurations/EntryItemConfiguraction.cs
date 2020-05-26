using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class EntryItemConfiguraction : IEntityTypeConfiguration<EntryItem>
    {
        public void Configure(EntityTypeBuilder<EntryItem> builder)
        {
            builder.HasKey(x => new { x.EntryID, x.ProductID });
        }
    }
}