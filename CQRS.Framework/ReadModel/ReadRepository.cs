using System.Data.Entity;
using System.Linq;

namespace CQRS.Framework.ReadModel
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseReadModel, new()
    {
        private DbContext _dbContext;

        public ReadRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        IQueryable<T> IReadRepository<T>.GetAll()
        {
            return this._dbContext.Set<T>().AsQueryable();
        }
    }
}
