using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Queries;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.RolesFeatures.Queries
{
    public sealed class GetAllRolesUtilTest
    {
         
        private readonly Mock<IRolesService> _roleService;

        public GetAllRolesUtilTest()
        {
            _roleService = new();
        }

        [Fact]
        public async Task GetAllRoleQueryResponseShouldBeNotNull()
        {
           
            _roleService.Setup(x=>
            x.GetAllRolesAsync())
                .ReturnsAsync(new List<AppRole>());

        }

    }
}
