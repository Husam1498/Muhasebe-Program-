using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.GenericRepository.AppDbContext.CompanyRepositories;
using OMPS.DomainKatmani.UnitOfWorks;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public class CompanyServices : ICompanyServices
    {
        /// <summary>
        /// name arama
        /// </summary>
        private static readonly Func<AppDbContext, string, Task<Company?> > 
            GetCompanybyNameCompiled = EF.CompileAsyncQuery((AppDbContext context, string name) => 
                context.Set<Company>()
                .FirstOrDefault(c => c.Name == name));

        private readonly ICompanyCommandRepository _companyCommandRepository;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        private readonly IAppUnitOfWorks _appUnitOfWorks;
        private readonly IMapper _ımapper;
        public CompanyServices(ICompanyCommandRepository context, IMapper ımapper,
            IAppUnitOfWorks appUnitOfWorks, ICompanyQueryRepository companyQueryRepository)
        {
            _companyCommandRepository = context;
            _ımapper = ımapper;
            _appUnitOfWorks = appUnitOfWorks;
            _companyQueryRepository = companyQueryRepository;
        }
        //Create COmpany
        public async Task CreateCompanyAsync(CreateCompayCommand request, CancellationToken cancellationToken)
        {
            Company company = _ımapper.Map<Company>(request);
            await _companyCommandRepository.AddAsync(company,cancellationToken);
            await _appUnitOfWorks.SaveChangesAsync(cancellationToken);

        }

        //şiirket adı ile şirket getir
        public async Task<Company?> GetCompanyByName(string name)
        {
            return await _companyQueryRepository.GetFirstByExpression(p => p.Name == name);
        }

        public async Task MigrateCompanyDatabases()
        {
            var companies = await _companyQueryRepository.GetAll().ToListAsync();
            foreach (var company in companies)
            {
                var db = new CompanyDbContext(company);

                await db.Database.MigrateAsync();

            }
        }
    }
}
