using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using System.Reflection.Metadata.Ecma335;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole
{
    public sealed class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
    {
        private IRolesService _rolesService;

        public CreateRoleHandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
        {
           AppRole role= await _rolesService.GetByCode(request.Code);

            if (role!=null) throw new Exception("Bu rol zaten mevcut");

      
            await _rolesService.AddAsync(request);
           return new();
        }
    }
}
