using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleAndRoleRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleAndRole
{
    public sealed class MainRoleAndRoleCommandRepository : AppCommandRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleCommandRepo
    {
        public MainRoleAndRoleCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
