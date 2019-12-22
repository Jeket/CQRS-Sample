namespace CQRS_Query.Core
{
    public interface IQueryHandler<TQuery, TResult>
    where TQuery : IQuery<TResult>
    {
        TResult Process(TQuery query);
    }
}
