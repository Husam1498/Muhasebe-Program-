using OMPS.DomainKatmani.Abstractions;

namespace OMPS.DomainKatmani.Repository.GenericRepository.CompanyDbContext
{
    public interface ICompanyDbQueryRepo<T>:ICompanyDbRepository,IQueryGenericRepository<T> where T : Entity
    {

    }
}
