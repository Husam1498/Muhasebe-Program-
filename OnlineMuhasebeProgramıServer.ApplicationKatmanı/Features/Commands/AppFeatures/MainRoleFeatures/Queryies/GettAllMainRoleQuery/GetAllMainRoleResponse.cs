using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Queryies.GettAllMainRoleQuery
{
    public sealed record GetAllMainRoleResponse(IList<MainRole> allRoles);

}
