using CQRS_Query.Core;
using CQRS_Query.Models;
using CQRS_Query.Queries;

namespace CQRS_Query.QueryHandlers
{
    public class GetCategoryQueryHandler : IQueryHandler<GetCategoryQuery, Category[]>
    {
        public Category[] Process(GetCategoryQuery query)
        {
            // select category from database logic...
            return null;
        }
    }
}