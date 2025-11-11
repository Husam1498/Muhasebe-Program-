using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.RemoveMainRoleAndUser
{
    public sealed class RemoveByIdMainRoleAndUserhandler :
        ICommandHandler<RemoveByIdMainRoleAndUserCommand, RemoveByIdMainRoleAndUserResponse>
    {
        private readonly IMainRoleAndUserServices _mainRoleAndUserServices;

        public RemoveByIdMainRoleAndUserhandler(IMainRoleAndUserServices mainRoleAndUserServices)
        {
            _mainRoleAndUserServices = mainRoleAndUserServices;
        }

        public async Task<RemoveByIdMainRoleAndUserResponse> Handle(RemoveByIdMainRoleAndUserCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationship checkEntity = await _mainRoleAndUserServices.GetById(
                request.id
                );
            if (checkEntity == null) throw new Exception("Bu rol mevcut değildir!!!");

            await _mainRoleAndUserServices.RemoveByIdAsync( request.id );

            return new();
        }
    }
}
