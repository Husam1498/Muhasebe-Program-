using Microsoft.EntityFrameworkCore;

namespace OMPS.DomainKatmani.Repository.GenericRepository.CompanyDbContext
{
    public interface  ICompanyDbRepository
    {
        void CreateDbContextInstance(DbContext context);// iki tane context olduğu için crud işlemlerinde hangi veirtabanına göndereceğini belirlemek içn
    }
}
