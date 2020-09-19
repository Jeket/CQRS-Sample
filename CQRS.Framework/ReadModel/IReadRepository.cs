using System.Linq;

namespace CQRS.Framework.ReadModel
{
    public interface IReadRepository<T> where T : BaseReadModel
    {
        IQueryable<T> Get();
    }
}
