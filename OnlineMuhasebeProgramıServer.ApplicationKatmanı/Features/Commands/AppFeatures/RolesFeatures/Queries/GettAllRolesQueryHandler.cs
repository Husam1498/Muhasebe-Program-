using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Queries
{
    public sealed class GettAllRolesQueryHandler : IQueryhandler<GetAllRolesQueryt, GetAllRoleQueryResponse>
    {
        private readonly IRolesService _rolesService;

        public GettAllRolesQueryHandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<GetAllRoleQueryResponse> Handle(GetAllRolesQueryt request, CancellationToken cancellationToken)
        {
           IList<AppRole> roles=await _rolesService.GetAllRolesAsync();

            return  new GetAllRoleQueryResponse (roles);
        }
    }
}
