using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.RemoveById
{
    public sealed record RemoveByIdMRARFCommand(string id) : ICommand<RemoveByIdMRARFResponse>
    {
    }
}
