using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ObjectValue;
using QuickBuy.Repository.Configs;

namespace QuickBuy.Repository.Contexts
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        
        public QuickBuyContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderItemConfig());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new AddressConfig());

            modelBuilder.Entity<PaymentMethod>()
                .HasData(
                    new PaymentMethod { Id = 1, Name = "Boleto Bancário", Description = "Forma de pagamento Boleto Bancário" },
                    new PaymentMethod { Id = 2, Name = "Cartão de Crédito", Description = "Forma de pagamento Cartão de Crédito" },
                    new PaymentMethod { Id = 3, Name = "Depósito Bancário", Description = "Forma de pagamento Depósito Bancário" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
