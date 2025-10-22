using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMPS.DomainKatmani.AppEntities
{
    public sealed class MainRoleAndRoleRelationship:Entity
    {
        [ForeignKey(nameof(AppRole))]
        public string RoleId { get; set; }
        public AppRole AppRole { get; set; }

        [ForeignKey(nameof(MainRole))]
        public string MainRoleId { get; set; }
        public MainRole MainRole { get; set; }
    }
}
