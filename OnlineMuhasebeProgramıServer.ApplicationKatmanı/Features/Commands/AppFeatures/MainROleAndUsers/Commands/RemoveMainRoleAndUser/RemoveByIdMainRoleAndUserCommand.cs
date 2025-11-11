using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.RemoveMainRoleAndUser
{
    public sealed record RemoveByIdMainRoleAndUserCommand(string id) : 
        ICommand<RemoveByIdMainRoleAndUserResponse>
    {
    }
}
