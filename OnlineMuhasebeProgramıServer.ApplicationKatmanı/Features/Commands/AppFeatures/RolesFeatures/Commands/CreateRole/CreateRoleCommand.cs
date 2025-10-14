using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(string Code, string Name): ICommand<CreateRoleCommandResponse>;

}
