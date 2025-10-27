using OMPS.DomainKatmani.Abstractions;

namespace OMPS.DomainKatmani.Repository.GenericRepository.CompanyDbContext
{
    public interface ICompanyDbCommandRepo<T>:ICompanyDbRepository,ICommandGenericRepository<T> where T : Entity
    {

    }
}
