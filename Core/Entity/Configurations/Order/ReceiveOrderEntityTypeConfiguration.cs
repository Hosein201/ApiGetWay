using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Order
{
    public class ReceiveOrderEntityTypeConfiguration : IEntityTypeConfiguration<Models.ReceiveOrder>
    {
        public void Configure(EntityTypeBuilder<Models.ReceiveOrder> builder)
        {
            builder.ToTable("ReceiveOrder", "order");
            builder.HasKey(h => h.Id);
            builder.Property(p => p.ProductName).IsRequired(true);
            builder.Property(p => p.WriterName).IsRequired(true);
            builder.Property(p => p.ReceiveTime).IsRequired(true);
        }
    }
}
