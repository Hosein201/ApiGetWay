using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "identity");
            builder.HasKey(h => h.Id);
            builder.HasOne(h => h.Customer)
                   .WithOne(w => w.User)
                   .HasForeignKey<Models.Customer.Customer>(f => f.UserId)
                   .IsRequired();

        }
    }
}
