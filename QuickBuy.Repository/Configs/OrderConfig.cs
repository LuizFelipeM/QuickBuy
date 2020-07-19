using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Configs
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.HasIndex(o => o.Id);

            builder.Property(o => o.OrderDate)
                .HasDefaultValueSql("current_date")
                .IsRequired();
            builder.Property(o => o.ExpectedDeliveryDate)
                .IsRequired();

            // Relationships
            builder.HasMany(o => o.OrderItems);

            builder.HasOne(o => o.Address)
                .WithOne();
        }
    }
}
