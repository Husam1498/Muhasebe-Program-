
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Queries
{
    public sealed record GetAllRoleQueryResponse(IList<AppRole> Roles);

}
