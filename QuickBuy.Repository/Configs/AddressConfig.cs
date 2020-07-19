using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Repository.Configs
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.CEP)
                .IsRequired();
            builder.Property(a => a.State)
                .IsRequired();
            builder.Property(a => a.City)
                .IsRequired();
            builder.Property(a => a.Street)
                .IsRequired();
            builder.Property(a => a.Number)
                .IsRequired();

            builder.HasIndex(a => a.Id);
        }
    }
}
