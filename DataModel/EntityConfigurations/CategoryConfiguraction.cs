using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class CategoryConfiguraction : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(category => category.Name).HasMaxLength(100).IsRequired();
            builder.HasIndex(category => category.Name).IsUnique();
        }
    }
}