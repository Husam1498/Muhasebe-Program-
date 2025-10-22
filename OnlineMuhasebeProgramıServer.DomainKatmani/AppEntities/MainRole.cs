using OMPS.DomainKatmani.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMPS.DomainKatmani.AppEntities
{
    public sealed class MainRole:Entity
    {
        public string Title { get; set; }
        [ForeignKey(nameof(Company))]
        public string CompanyId { get; set; }
        public Company? Company { get; set; }
        public bool IsRoleCreatedByAdmin { get; set; }

    }
}
