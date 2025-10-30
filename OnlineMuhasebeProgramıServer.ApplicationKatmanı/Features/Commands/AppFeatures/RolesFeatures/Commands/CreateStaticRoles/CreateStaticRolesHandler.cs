using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using OMPS.DomainKatmani.Roles;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateAllRoles
{
    public sealed class CreateStaticRolesHandler :
        ICommandHandler<CreateStaticRolesCommand, CreateStaticRolesResponse>
    {
        private readonly IRolesService _rolesService;

        public CreateStaticRolesHandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<CreateStaticRolesResponse> Handle(CreateStaticRolesCommand request, CancellationToken cancellationToken)
        {
            IList<AppRole> originalRoleList = RolesList.GetStaticRoles();
            IList<AppRole> newRoleList = new List<AppRole>();

            foreach (var role in originalRoleList)
            {
                AppRole checkRole = await _rolesService.GetByCode(role.Code);
                if (checkRole == null) newRoleList.Add(role);

            }

            await _rolesService.AddRange(newRoleList);

            return new();
        }
    }
}
