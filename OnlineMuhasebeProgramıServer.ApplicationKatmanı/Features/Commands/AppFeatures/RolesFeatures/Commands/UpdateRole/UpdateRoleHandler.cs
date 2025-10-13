using MediatR;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, UpdateRoleResponse>
    {
        private readonly IRolesService _rolesService;

        public UpdateRoleHandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
        {
             AppRole role = await _rolesService.GetById(request.Id);
             if (role==null) throw new Exception("Role Bulunamdı");

             if(role.Code!=request.Code)
             {
                 AppRole codeCheck = await _rolesService.GetByCode(request.Code);
                 if (codeCheck!=null) throw new Exception("Role Code Zaten Kayıtlı");
             
             }
             role.Code=request.Code;
             role.Name=request.Name;

             await _rolesService.UpdateAsync(role);

             return new();

        }
    }
}
