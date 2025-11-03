using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleAndRoleRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleAndRole
{
    public class MainRoleAndRoleQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleQueryRepo
    {
        public MainRoleAndRoleQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
