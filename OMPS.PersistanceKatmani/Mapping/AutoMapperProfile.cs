
using AutoMapper;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.PersistanceKatmani.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCompayRequest, Company>().ReverseMap();
        }

    }
}

