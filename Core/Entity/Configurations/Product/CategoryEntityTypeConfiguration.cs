using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Product
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Models.Category>
    {
        public void Configure(EntityTypeBuilder<Models.Category> builder)
        {
            builder.ToTable("Category", "Pro");
            builder.HasKey(h => h.Id); ;
            builder.HasMany(h => h.SubCategories)
                   .WithOne(w => w.Category);
        }
    }
}
