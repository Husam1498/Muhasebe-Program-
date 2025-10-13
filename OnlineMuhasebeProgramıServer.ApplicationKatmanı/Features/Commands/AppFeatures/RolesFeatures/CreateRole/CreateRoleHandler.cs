using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.AppEntities.Identity;
using System.Reflection.Metadata.Ecma335;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.CreateRole
{
    public sealed class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
    {
        private readonly RoleManager<AppRole> _roleManager;

        public CreateRoleHandler(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
        {
           AppRole role= await _roleManager.Roles.Where(r => r.Code == request.Code)
                .FirstOrDefaultAsync();

            if (role!=null) throw new Exception("Bu rol zaten mevcut");

            AppRole newRole = new()
            {
                Id= Guid.NewGuid().ToString(),
                Code = request.Code,
                Name = request.Name
            };

            var result= await _roleManager.CreateAsync(newRole);
            if (!result.Succeeded) throw new Exception("Rol oluşturulamadı");
          
            return new();
        }
    }
}
