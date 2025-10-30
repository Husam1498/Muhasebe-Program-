using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
    public class CreateMainRoleCommandsHandler : ICommandHandler<CreateMainRoleCommand, CreatemainRoleCommandsResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public CreateMainRoleCommandsHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<CreatemainRoleCommandsResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
        {
            MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title,request.CompanyId,cancellationToken);
           
            if (checkMainRoleTitle != null) throw new Exception("Bu rol Daha Önce kaydedilmiştir");

            MainRole mainRole = new(
                Guid.NewGuid().ToString(),
                request.Title,
                request.CompanyId,
                request.IRoleCreatedByAdmin
                );  
            await _mainRoleService.CreateAsync( mainRole, cancellationToken );

            return new();
        }
    }
}
