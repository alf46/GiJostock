using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{
    public class UserConfiguraction : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(category => category.Username).HasMaxLength(100).IsRequired();
            builder.HasIndex(category => category.Username).IsUnique();

            builder.Property(user => user.Password).HasMaxLength(30).IsRequired();

            builder.Property(user => user.FirstName).HasMaxLength(100);
            builder.Property(user => user.LastName).HasMaxLength(100);
            builder.Property(user => user.Email).HasMaxLength(200).IsRequired();
        }
    }
}