namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string Email,
        string UserId,
        string NameLastName);
  
}
