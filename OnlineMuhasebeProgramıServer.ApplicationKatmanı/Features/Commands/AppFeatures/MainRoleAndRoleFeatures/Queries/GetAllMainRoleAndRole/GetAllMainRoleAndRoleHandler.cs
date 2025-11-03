using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Queries.GetAllMainRoleAndRole
{
    public sealed class GetAllMainRoleAndRoleHandler : IQueryhandler<GetAllMainRoleAndRoleQuery,GetAllMainRoleAndRoleResponse>
    {
        private readonly IMainRoleAndRoleRelationshipServices _mainRoleService;

        public GetAllMainRoleAndRoleHandler(IMainRoleAndRoleRelationshipServices mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<GetAllMainRoleAndRoleResponse> Handle(GetAllMainRoleAndRoleQuery query,CancellationToken cancellationToken)
        {
            return new(await _mainRoleService.
                GetAll()
                .Include("AppRole")
                .Include("MainRole")//oluştuırduğumuz entity ismi ile çağırıyoruz
                .ToListAsync()
                );
        }
    }
}
