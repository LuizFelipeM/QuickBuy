using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(p => p.Description)
                .HasColumnType("text")
                .IsRequired();
            builder.Property(p => p.Price)
                .IsRequired();
        }
    }
}
