using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.CreateMainRoleAndUser
{
    public sealed class CreateMainRoleAndUserHandler : ICommandHandler<CreateMainRoleAndUserCommand, CreateMainRoleAndUserResponse>
    {
        private readonly IMainRoleAndUserServices _mainRoleAndUserServices;

        public CreateMainRoleAndUserHandler(IMainRoleAndUserServices mainRoleAndUserServices)
        {
            _mainRoleAndUserServices = mainRoleAndUserServices;
        }

        public async Task<CreateMainRoleAndUserResponse> Handle(CreateMainRoleAndUserCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationship entity = await _mainRoleAndUserServices.GetByUserIdCompanyIdAndRoleIdAsync(
                userId : request.userId,
                companyId: request.companyId,
                mainRoleId: request.mainRoleId
                );
            if (entity != null) throw new Exception("Bu ilişki daha önce tanımlanmışştır");

            await _mainRoleAndUserServices.CreateAsync(new MainRoleAndUserRelationship(
                id:Guid.NewGuid().ToString(),
                userId: request.userId,
                companyId: request.companyId,
                mainRoleId:request.mainRoleId            
                ),
                cancellationToken);

            return new();
        }
    }
}
