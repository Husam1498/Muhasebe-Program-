using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.DeleteRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.RolesFeatures.Commands
{
    public sealed class DeleteRoleUnitTest
    {
        private readonly Mock<IRolesService> _roleService;

        public DeleteRoleUnitTest()
        {
            _roleService = new();
         
        }

        [Fact]
        public async Task AppRoleShouldNotBe()
        {
            #region Kod Kısmı
            /*
                AppRole role = await _rolesService.GetById(request.Id);
                if (role==null) throw new Exception("Role Bulunamdı");
             */
            #endregion

            _ = _roleService.Setup(x =>
            x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());
        }


        [Fact]
        public async Task DeleteRoleResponeShouldNotBeNull()
        {
            #region Kod Kısmı
            /*
                await _rolesService.DeleteAsync(role);
             */
            #endregion

            var command = new DeleteroleCommands(
                
                Id: "4308b8fd-dc22-45c0-a8b2-acbaaafb2c3d"
                );

            _ = _roleService.Setup(x =>
            x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());

            var handler= new DeleteRoleCommandHandler(_roleService.Object);

            var response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeNull();
        }
    }
}
