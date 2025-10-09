using AutoMapper;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public class CompanyServices : ICompanyServices
    {
        private readonly AppDbContext _context;
        private readonly IMapper _ımapper;
        public CompanyServices(AppDbContext context, IMapper ımapper)
        {
            _context = context;
            _ımapper = ımapper;
        }
        //Create COmpany
        public async Task CreateCompanyAsync(CreateCompayRequest request)
        {
            Company company = _ımapper.Map<Company>(request);
            //company.Id = Guid.NewGuid().ToString();
            await _context.Set<Company>().AddAsync(company);
            await _context.SaveChangesAsync();

        }
    }
}
