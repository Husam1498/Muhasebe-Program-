using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Roles;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRole
{
    public sealed class CreateStaticMainRoleCommandsHandler : ICommandHandler<CreateStaticMainRoleCommand, CreateStaticMainRolecommandsResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public CreateStaticMainRoleCommandsHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<CreateStaticMainRolecommandsResponse> Handle(CreateStaticMainRoleCommand request, CancellationToken cancellationToken)
        {
            List<MainRole> mainRoles = RolesList.GetStaticMainRoles();
            List<MainRole> newMainRoles = new List<MainRole>();
            foreach (var role in mainRoles)
            { 
                MainRole checkMainRole= await _mainRoleService
                    .GetByTitleAndCompanyId(role.Title, role.CompanyId, cancellationToken);

                if (checkMainRole == null) newMainRoles.Add(role);
                
            }
            await _mainRoleService.CreateRangeAsync(newMainRoles,cancellationToken);

            return new();

        }
    }
}
