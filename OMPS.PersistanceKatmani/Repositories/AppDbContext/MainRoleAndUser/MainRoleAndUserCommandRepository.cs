using OMPS.DomainKatmani.AppEntities;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleAndUser
{
    public sealed class MainRoleAndUserCommandRepository : AppCommandRepository<MainRoleAndUserRelationship>
    {        
        public MainRoleAndUserCommandRepository(Context.AppDbContext context) : base(context)
        {
     
        }


    }
}
