using Microsoft.AspNetCore.Identity;

namespace OMPS.DomainKatmani.AppEntities.Identity
{
    public sealed class AppRole:IdentityRole<string>
    {
        public string Code { get; set; }
    }
}
