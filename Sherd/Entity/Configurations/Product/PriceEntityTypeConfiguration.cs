using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Product
{
    public class PriceEntityTypeConfiguration : IEntityTypeConfiguration<Models.Product.Price>
    {
        public void Configure(EntityTypeBuilder<Models.Product.Price> builder)
        {
            builder.ToTable("Price", "Pro");
            builder.HasKey(h => h.Id); ;
        }
    }
}
