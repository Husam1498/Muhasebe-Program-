using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed record  UpdateMainRoleCommand(string id, string title)
        : ICommand<UpdateMainRoleResponse>
    {
    }
}
