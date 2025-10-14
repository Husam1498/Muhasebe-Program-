using MediatR;

namespace OMPS.ApplicationKatmanı.Messaging
{
   public interface IQuery<out TResponse> : IRequest<TResponse>
    {

    }
}
