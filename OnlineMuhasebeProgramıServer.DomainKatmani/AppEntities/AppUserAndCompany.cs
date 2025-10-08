using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Çoka çok ilişki(many to many relationship) Company- AppUser için oluşturuldu.
namespace OMPS.DomainKatmani.AppEntities
{
    public sealed class AppUserAndCompany:Entity
    {
        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public AppUser  AppUser { get; set; }

        [ForeignKey(nameof(Company))]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
