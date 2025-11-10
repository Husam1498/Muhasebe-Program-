using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;
// Çoka çok ilişki(many to many relationship) Company- AppUser için oluşturuldu.
namespace OMPS.DomainKatmani.AppEntities
{
    public sealed class AppUserAndCompany:Entity
    {
        public AppUserAndCompany()
        {
            
        }

        public AppUserAndCompany(string id,string userId, string companyId):base(id)
        {
            UserId = userId;
            CompanyId = companyId;
        }

        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public AppUser  AppUser { get; set; }

        [ForeignKey(nameof(Company))]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
