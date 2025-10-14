using MediatR;

namespace OMPS.ApplicationKatmanı.Messaging
{
    public interface IQueryhandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
        where TQuery : IQuery<TResponse>
    {

    }
}
