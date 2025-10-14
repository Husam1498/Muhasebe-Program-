using MediatR;

namespace OMPS.ApplicationKatmanı.Messaging
{
    public interface ICommand<out TResponse>: IRequest<TResponse>
    {


    }
}
