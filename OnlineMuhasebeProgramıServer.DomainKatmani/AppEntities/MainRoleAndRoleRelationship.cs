using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMPS.DomainKatmani.AppEntities
{
    public sealed class MainRoleAndRoleRelationship:Entity
    {
        public MainRoleAndRoleRelationship()
        {
        }

        public MainRoleAndRoleRelationship(string ıd,string roleId, string mainRoleId) : base(ıd)
        {
            RoleId = roleId;
            MainRoleId = mainRoleId;
        }

        [ForeignKey(nameof(AppRole))]
        public string RoleId { get; set; }
        public AppRole AppRole { get; set; }

        [ForeignKey(nameof(MainRole))]
        public string MainRoleId { get; set; }
        public MainRole MainRole { get; set; }
    }
}
