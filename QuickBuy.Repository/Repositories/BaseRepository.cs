using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContext QuickBuyContext;

        public BaseRepository(QuickBuyContext quickBuyContext) => QuickBuyContext = quickBuyContext;

        public IEnumerable<TEntity> GetAll() => QuickBuyContext.Set<TEntity>().ToList();

        public TEntity GetById(int id) => QuickBuyContext.Set<TEntity>().Find(id);

        public void Add(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Add(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Update(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            QuickBuyContext.Remove(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Dispose() => QuickBuyContext.Dispose();
    }
}
