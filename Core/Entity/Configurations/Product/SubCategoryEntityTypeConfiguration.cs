using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Product
{
    public class SubCategoryEntityTypeConfiguration : IEntityTypeConfiguration<Models.SubCategory>
    {
        public void Configure(EntityTypeBuilder<Models.SubCategory> builder)
        {
            builder.ToTable("SubCategory", "Pro");
            builder.HasKey(h => h.Id);
            builder.HasMany(h => h.Products)
                   .WithOne(w => w.SubCategory);
        }
    }
}
