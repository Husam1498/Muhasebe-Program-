using OMPS.DomainKatmani.AppEntities;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleAndUser
{
    public sealed class MainRoleAndUserQueryRepository : AppQueryRepository<MainRoleAndUserRelationship>
    {
        public MainRoleAndUserQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
