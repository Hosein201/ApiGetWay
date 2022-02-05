﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Order
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Models.Order.Order>
    {
        public void Configure(EntityTypeBuilder<Models.Order.Order> builder)
        {
            builder.ToTable("Orders", "order");
            builder.HasKey(h => h.Id);
        }
    }
}