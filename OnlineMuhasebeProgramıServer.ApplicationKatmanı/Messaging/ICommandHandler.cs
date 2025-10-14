using MediatR;

namespace OMPS.ApplicationKatmanı.Messaging
{
    public interface ICommandHandler<in TCommand,TResponse>: IRequestHandler<TCommand,TResponse>
        where TCommand :ICommand<TResponse>
    {
    }
}
