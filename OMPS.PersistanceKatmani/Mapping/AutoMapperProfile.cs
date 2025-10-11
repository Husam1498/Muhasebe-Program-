
using AutoMapper;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.CompanyEnties;

namespace OMPS.PersistanceKatmani.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCompayRequest, Company>().ReverseMap();
            CreateMap<CreateUCAFRequest, UCAF>().ReverseMap();
        }

    }
}

