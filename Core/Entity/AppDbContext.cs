using Entity.Models;
using Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entity
{
    public class AppDbContext : IdentityDbContext<User, Role, Guid,
        IdentityUserClaim<Guid>,
        UserRoles,
        IdentityUserLogin<Guid>,
        IdentityRoleClaim<Guid>,
        IdentityUserToken<Guid>>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var entitis = typeof(IEntity).Assembly;
            builder.RegisterAllEntities<IEntity>(entitis);
            builder.RegisterEntityTypeConfiguration(entitis);
        }
    }
}
