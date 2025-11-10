using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.CreateAppUserAndComapny
{
    public sealed record CreateAppUserAndComapnyCommand(
        string userId, string companyId) : ICommand<CreateAppUserAndComapnyResponse>
    {
        
    }
}
