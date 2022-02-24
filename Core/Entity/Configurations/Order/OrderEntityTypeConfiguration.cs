using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Order
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Models.Order>
    {
        public void Configure(EntityTypeBuilder<Models.Order> builder)
        {
            builder.ToTable("Orders", "order");
            builder.HasKey(h => h.Id);
            builder.Property(p => p.ProductName).IsRequired(true);
            builder.HasIndex(p => p.Code).IsUnique(true);
        }
    }
}
