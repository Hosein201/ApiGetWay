using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Customer
{
    class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Models.Customer.Customer>
    {
        public void Configure(EntityTypeBuilder<Models.Customer.Customer> builder)
        {
            builder.ToTable("Customers", "Cus");
            builder.HasKey(h => h.Id);
        }
    }
}
