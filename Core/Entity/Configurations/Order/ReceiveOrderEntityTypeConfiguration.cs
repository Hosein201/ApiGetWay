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
        }
    }
}
