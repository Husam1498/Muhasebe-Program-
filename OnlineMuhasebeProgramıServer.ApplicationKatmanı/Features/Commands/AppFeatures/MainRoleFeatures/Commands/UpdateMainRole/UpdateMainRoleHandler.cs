using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed class UpdateMainRoleHandler : ICommandHandler<UpdateMainRoleCommand, UpdateMainRoleResponse>
    {
        private readonly IMainRoleService _mainRoleService;
        public UpdateMainRoleHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<UpdateMainRoleResponse> Handle(UpdateMainRoleCommand request, CancellationToken cancellationToken)
        {
            MainRole mainRole = await _mainRoleService.GetById(request.id);
            if (mainRole == null) throw new Exception("Role Bulunamadı!!");

            if(mainRole.Title== request.title) throw new Exception("Ayni isimde günceleyemezsiniz!!");
            if(mainRole.Title!= request.title)
            {
                MainRole checkMainRole = await _mainRoleService.GetByTitleAndCompanyId(
                    request.title, mainRole.CompanyId,cancellationToken);
                if (checkMainRole != null) throw new Exception("Bu rol adı daha önce kullanılmış");

            }
            mainRole.Title = request.title;
            await _mainRoleService.UpdateAsync(mainRole);
            
            return new UpdateMainRoleResponse();
        }
    }
}
