﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations.Order
{
    public class RejectOrderEntityTypeConfiguration : IEntityTypeConfiguration<Models.RejectOrder>
    {
        public void Configure(EntityTypeBuilder<Models.RejectOrder> builder)
        {
            builder.ToTable("RejectOrder", "order");
            builder.HasKey(h => h.Id);
            builder.Property(p => p.ProductName).IsRequired(true);
            builder.Property(p => p.WriterName).IsRequired(true);
            builder.Property(p => p.RejectTime).IsRequired(true);
        }
    }
}
