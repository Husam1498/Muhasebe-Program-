using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Queries.GetAllMainRoleAndRole
{
    public sealed record GetAllMainRoleAndRoleResponse
        (List<MainRoleAndRoleRelationship> roles);
   
}
