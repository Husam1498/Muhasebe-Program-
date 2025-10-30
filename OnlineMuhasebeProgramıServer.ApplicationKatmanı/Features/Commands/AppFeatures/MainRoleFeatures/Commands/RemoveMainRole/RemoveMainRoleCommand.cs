using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole
{
    public sealed record RemoveMainRoleCommand(string Id) : ICommand<RemoveMainRoleResponse>
    {
    }
}
