using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMPS.DomainKatmani.AppEntities;

public sealed class MainRoleAndUserRelationship:Entity
{
    public MainRoleAndUserRelationship()
    {
        
    }

    public MainRoleAndUserRelationship(
        string id,string userId, string mainRoleId, string companyId): base(id)
    {
        UserId = userId;
        MainRoleId = mainRoleId;
        CompanyId = companyId;
    }

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
