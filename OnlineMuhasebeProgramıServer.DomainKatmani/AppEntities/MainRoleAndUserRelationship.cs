using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMPS.DomainKatmani.AppEntities;

public sealed class MainRoleAndUserRelationship:Entity
{
    [ForeignKey(nameof(AppRole))]
    public string  UserId { get; set; }
    public AppUser AppUser { get; set; }

    [ForeignKey(nameof(MainRole))]
    public string MainRoleId { get; set; }
    public MainRole MainRole { get; set; }

    [ForeignKey(nameof(Company))]
    public string CompanyId { get; set; }
    public Company Company { get; set; }

}
