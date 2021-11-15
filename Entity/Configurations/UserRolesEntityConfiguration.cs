using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations
{
    public class UserRolesEntityConfiguration : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.ToTable("Roles", "identity");
            builder.HasOne(h => h.User)
                   .WithMany(w => w.UserRoles)
                   .HasForeignKey(f => f.UserId)
                   .IsRequired();

            builder.HasOne(h => h.Role)
                   .WithMany(w => w.UserRoles)
                   .HasForeignKey(f => f.RoleId)
                   .IsRequired();
        }
    }
}
