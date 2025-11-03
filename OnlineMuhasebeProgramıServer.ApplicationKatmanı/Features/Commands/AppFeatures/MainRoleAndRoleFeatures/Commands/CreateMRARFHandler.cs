using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands
{
    public sealed class CreateMRARFHandler : ICommandHandler<CreateMRARFCommand, CreateMRARFResponse>
    {
        private readonly IMainRoleAndRoleRelationshipServices _mainRoleServis;

        public CreateMRARFHandler(IMainRoleAndRoleRelationshipServices mainRoleServis)
        {
            _mainRoleServis = mainRoleServis;
        }

        public async Task<CreateMRARFResponse> Handle(CreateMRARFCommand request,
            CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationship checkMainRoleAndUserIsRelated = await
                _mainRoleServis.GetByRoleIdAndMainRoleId(request.roleId,request.mainRoleId,
                cancellationToken);

            if (checkMainRoleAndUserIsRelated != null) throw new Exception("Bu ilişkili rol daha önce mevcuttur");

            MainRoleAndRoleRelationship mainRoleAndRole = new(
                Guid.NewGuid().ToString(),
                request.roleId,
                request.mainRoleId
                );

            await _mainRoleServis.CreateAsync(mainRoleAndRole, cancellationToken);

            return new();
        }
    }
}
