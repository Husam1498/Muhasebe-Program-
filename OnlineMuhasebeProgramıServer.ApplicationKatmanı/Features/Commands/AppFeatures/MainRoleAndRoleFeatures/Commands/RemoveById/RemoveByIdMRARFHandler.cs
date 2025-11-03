using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.RemoveById
{
    public sealed class RemoveByIdMRARFHandler : ICommandHandler<RemoveByIdMRARFCommand, RemoveByIdMRARFResponse>
    {
        private readonly IMainRoleAndRoleRelationshipServices _mainRoleAndRoleRelationshipServices;

        public RemoveByIdMRARFHandler(IMainRoleAndRoleRelationshipServices mainRoleAndRoleRelationshipServices)
        {
            _mainRoleAndRoleRelationshipServices = mainRoleAndRoleRelationshipServices;
        }



        public async Task<RemoveByIdMRARFResponse> Handle(RemoveByIdMRARFCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationship mainRole = await
                _mainRoleAndRoleRelationshipServices.GetByIdAsync(request.id);

            if (mainRole == null) throw new Exception("Böyle bir id Yok lütfen Kontrol Ediniz");


            await _mainRoleAndRoleRelationshipServices.RemoveByIdAsync(request.id);
            return new();
        }
    }
}
