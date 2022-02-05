using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Product
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Models.Product.Product>
    {
        public void Configure(EntityTypeBuilder<Models.Product.Product> builder)
        {
            builder.ToTable("Products", "Pro");
            builder.HasKey(h => h.Id);
            builder.HasMany(h => h.Prices)
                   .WithOne(w => w.Product);
        }
    }
}
