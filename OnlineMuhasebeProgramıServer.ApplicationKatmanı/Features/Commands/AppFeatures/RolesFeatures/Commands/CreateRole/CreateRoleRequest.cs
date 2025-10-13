using MediatR;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole
{
    public sealed class CreateRoleRequest: IRequest<CreateRoleResponse>
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
