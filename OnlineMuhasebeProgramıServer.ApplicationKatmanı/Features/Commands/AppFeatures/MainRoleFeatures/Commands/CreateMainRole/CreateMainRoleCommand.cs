using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
    public sealed record CreateMainRoleCommand(
        string Title,
        bool IRoleCreatedByAdmin =false,
        string CompanyId=null
    ): ICommand<CreatemainRoleCommandsResponse>;
}
