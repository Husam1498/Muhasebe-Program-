using Microsoft.AspNetCore.Identity;

namespace OMPS.DomainKatmani.AppEntities.Identity
{
    public sealed class AppUser:IdentityUser<string>
    {
        public string NameSurname { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefresTokenExpires { get; set; }


    }
}
