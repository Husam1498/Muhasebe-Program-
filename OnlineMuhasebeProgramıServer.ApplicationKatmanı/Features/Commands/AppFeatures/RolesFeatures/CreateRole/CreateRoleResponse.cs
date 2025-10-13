using MediatR;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.CreateRole
{
    public sealed class CreateRoleResponse
    {
        public string Message { get; set; }="Role başarıyla oluşturuldu.";
    }
}
