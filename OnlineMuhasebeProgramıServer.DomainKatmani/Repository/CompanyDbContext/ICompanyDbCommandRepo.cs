using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository.GenericRepository;

namespace OMPS.DomainKatmani.Repository.CompanyDbContext
{
    public interface ICompanyDbCommandRepo<T>:ICompanyDbRepository,ICommandGenericRepository<T> where T : Entity
    {

    }
}
