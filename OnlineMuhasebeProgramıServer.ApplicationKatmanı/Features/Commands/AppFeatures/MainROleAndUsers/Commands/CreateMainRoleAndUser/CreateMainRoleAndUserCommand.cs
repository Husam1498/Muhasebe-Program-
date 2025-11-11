using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.CreateMainRoleAndUser
{
    public sealed record CreateMainRoleAndUserCommand(string userId,
        string companyId,string mainRoleId) : ICommand<CreateMainRoleAndUserResponse>
    {
    }
}
