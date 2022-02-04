using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Product
{
    public class SubCategoryEntityTypeConfiguration : IEntityTypeConfiguration<Models.Product.SubCategory>
    {
        public void Configure(EntityTypeBuilder<Models.Product.SubCategory> builder)
        {
            builder.ToTable("SubCategory", "Pro");
            builder.HasKey(h => h.Id);
            builder.HasMany(h => h.Products)
                   .WithOne(w => w.SubCategory);
        }
    }
}
