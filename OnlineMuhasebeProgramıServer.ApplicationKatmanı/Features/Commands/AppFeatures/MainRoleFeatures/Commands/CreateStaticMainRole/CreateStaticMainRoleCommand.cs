using OMPS.ApplicationKatmanı.Messaging;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRole
{
    public sealed record CreateStaticMainRoleCommand( 
        List<MainRole> mainRoles
        ) : ICommand<CreateStaticMainRolecommandsResponse>;
}
