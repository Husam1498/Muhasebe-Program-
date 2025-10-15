using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
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

        private readonly AppDbContext _context;
        private readonly IMapper _ımapper;
        public CompanyServices(AppDbContext context, IMapper ımapper)
        {
            _context = context;
            _ımapper = ımapper;
        }
        //Create COmpany
        public async Task CreateCompanyAsync(CreateCompayCommand request, CancellationToken cancellationToken)
        {
            Company company = _ımapper.Map<Company>(request);
            await _context.Set<Company>().AddAsync(company,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

        }

        //şiirket adı ile şirket getir
        public async Task<Company?> GetCompanyByName(string name)
        {
            return await GetCompanybyNameCompiled(_context, name);
        }

        public async Task MigrateCompanyDatabases()
        {
            var companies = await _context.Set<Company>().ToListAsync();
            foreach (var company in companies)
            {
                var db = new CompanyDbContext(company);

                await db.Database.MigrateAsync();

            }
        }
    }
}
