using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository.GenericRepository;

namespace OMPS.DomainKatmani.Repository.CompanyDbContext
{
    public interface ICompanyDbQueryRepo<T>:ICompanyDbRepository,IQueryGenericRepository<T> where T : Entity
    {

    }
}
