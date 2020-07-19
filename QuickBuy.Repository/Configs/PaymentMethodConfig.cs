using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ObjectValue;
using System;

namespace QuickBuy.Repository.Configs
{
    public class PaymentMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(p => p.Description)
                .HasColumnType("text")
                .IsRequired();
        }
    }
}
