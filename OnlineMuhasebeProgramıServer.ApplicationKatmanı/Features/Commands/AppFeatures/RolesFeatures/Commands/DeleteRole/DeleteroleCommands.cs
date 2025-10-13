using MediatR;
using Microsoft.AspNetCore.Identity;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.DeleteRole
{
    public sealed class DeleteroleCommands:IRequest<DeleteRoleResponse>
    {
        public string Id { get; set; }
    }


    public sealed class DeleteRoleResponse
    {
        public string Message { get; set; } = "Role başarıyla silindi.";
    }

    public sealed class DeleteRoleHandler : IRequestHandler<DeleteroleCommands, DeleteRoleResponse>
    {
        private readonly IRolesService _rolesService;

        public DeleteRoleHandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<DeleteRoleResponse> Handle(DeleteroleCommands request, CancellationToken cancellationToken)
        {
            AppRole role = await _rolesService.GetById(request.Id);
            if (role == null) throw new Exception("Role Bulunamdı");

            await _rolesService.DeleteAsync(role);

            return new();
        }
    }
}
