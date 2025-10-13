
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Queries
{
    public sealed class GetAllRoleResponse
    {
        public IList<AppRole> Roles { get; set; } =default!;
    }
}
