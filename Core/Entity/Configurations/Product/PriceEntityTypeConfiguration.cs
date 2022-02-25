using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Product
{
    public class PriceEntityTypeConfiguration : IEntityTypeConfiguration<Models.Price>
    {
        public void Configure(EntityTypeBuilder<Models.Price> builder)
        {
            builder.ToTable("Price", "Pro");
            builder.HasKey(h => h.Id); ;
        }
    }
}
