using Microsoft.Extensions.DependencyInjection;
using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Repositories;

namespace QuickBuy.Web.Initializers
{
    public static class IoCDI
    {
        public static void Initializer(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
