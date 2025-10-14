namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string Email,
        string UserId,
        string NameLastName);
  
}
