using MediatR;
using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleCommandHandler : ICommandHandler<UpdateRoleCommand, UpdateRoleCommandResponse>
    {
        private readonly IRolesService _rolesService;

        public UpdateRoleCommandHandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<UpdateRoleCommandResponse> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
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
