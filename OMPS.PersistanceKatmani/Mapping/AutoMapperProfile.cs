
using AutoMapper;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole;
using OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.AppEntities.Identity;
using OMPS.DomainKatmani.CompanyEnties;

namespace OMPS.PersistanceKatmani.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCompayCommand, Company>().ReverseMap();
            CreateMap<CreateUCAFCommand, UCAF>().ReverseMap();
            CreateMap<CreateRoleCommand, AppRole>().ReverseMap();
        }

    }
}

