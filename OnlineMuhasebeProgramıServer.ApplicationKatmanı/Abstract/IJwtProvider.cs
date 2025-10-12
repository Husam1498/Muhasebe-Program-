using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.ApplicationKatmanı.Abstract
{
    public interface  IJwtProvider
    {
        Task<string> CreateTokenAsync(AppUser user, IList<string> roles);
    }
}
