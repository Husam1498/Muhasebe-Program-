using MediatR;
using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Queries
{
    public sealed record GetAllRolesQueryt:IQuery<GetAllRoleQueryResponse>
    {
    }
}
