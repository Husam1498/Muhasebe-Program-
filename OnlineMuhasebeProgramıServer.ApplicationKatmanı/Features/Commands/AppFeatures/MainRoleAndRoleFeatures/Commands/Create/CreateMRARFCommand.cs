using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.Create
{
    public sealed record CreateMRARFCommand(
        string roleId,
        string mainRoleId
        
        ) : ICommand<CreateMRARFResponse>;
   
}
