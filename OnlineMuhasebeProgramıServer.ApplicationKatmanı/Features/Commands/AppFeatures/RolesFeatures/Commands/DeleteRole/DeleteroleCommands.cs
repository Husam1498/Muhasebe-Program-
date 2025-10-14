using MediatR;
using Microsoft.AspNetCore.Identity;
using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;


namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.DeleteRole
{
    public sealed record DeleteroleCommands(string Id):ICommand<DeleteRoleCommandResponse>;
  
    public sealed record DeleteRoleCommandResponse(string Message = "Role başarıyla silindi.");

    public sealed class DeleteRoleCommandHandler : ICommandHandler<DeleteroleCommands, DeleteRoleCommandResponse>
    {
        private readonly IRolesService _rolesService;

        public DeleteRoleCommandHandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteroleCommands request, CancellationToken cancellationToken)
        {
            AppRole role = await _rolesService.GetById(request.Id);
            if (role == null) throw new Exception("Role Bulunamdı");

            await _rolesService.DeleteAsync(role);

            return new();
        }
    }
}
