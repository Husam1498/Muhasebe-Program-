using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole
{
    public sealed class RemoveMainRoleHandler : ICommandHandler<RemoveMainRoleCommand, RemoveMainRoleResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public RemoveMainRoleHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<RemoveMainRoleResponse> Handle(RemoveMainRoleCommand request, CancellationToken cancellationToken)
        {          
          
            await _mainRoleService.RemoveByIdAsync(request.Id);
            return new();
        }
    }
}
