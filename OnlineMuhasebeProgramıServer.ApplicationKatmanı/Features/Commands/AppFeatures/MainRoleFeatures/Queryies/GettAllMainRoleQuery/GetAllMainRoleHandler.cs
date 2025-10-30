using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Queryies.GettAllMainRoleQuery
{
    public sealed class GetAllMainRoleHandler : IQueryhandler<GetAllMainRoleQuery, GetAllMainRoleResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public GetAllMainRoleHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<GetAllMainRoleResponse> Handle(GetAllMainRoleQuery request, CancellationToken cancellationToken)
        {
            var result = _mainRoleService.GetAll();

            return new(await result.ToListAsync());
        }
    }
}
