using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Contexts;

namespace QuickBuy.Repository.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext) { }
    }
}
