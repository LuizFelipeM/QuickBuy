using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Repository.Configs
{
    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(o => o.Id);
            builder.HasIndex(o => o.Id);

            builder.Property(o => o.ProductId)
                .IsRequired();
            builder.Property(o => o.Quantity)
                .IsRequired();

            // Relationship
            builder.HasOne(o => o.Product)
                .WithOne();
        }
    }
}
