using System.Data.Entity;
using System.Linq;

namespace CQRS.Framework.ReadModel
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseReadModel, new()
    {
        private readonly DbContext _dbContext;

        public ReadRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Get()
        {
            return _dbContext.Set<T>().AsQueryable();
        }
    }
}
