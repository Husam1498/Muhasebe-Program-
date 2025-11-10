using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.RemoveById
{
    public sealed  record RemoveByIdAppUserAndComapnyCommand(string id) :
        ICommand<RemoveByIdAppUserAndComapnyResponse>
    {
    }
}
