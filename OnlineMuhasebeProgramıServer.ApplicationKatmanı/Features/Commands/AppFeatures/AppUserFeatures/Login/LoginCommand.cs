using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(
        string EmailOrUsername, string Password) :ICommand<LoginCommandResponse>;
}
