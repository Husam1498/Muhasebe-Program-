using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.UpdateRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.AppEntities.Identity;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.MainRoleFeatures
{
    public sealed class updateMainRoleUnitTest
    {

        private readonly Mock<IMainRoleService> _mainRoleService;

        public updateMainRoleUnitTest()
        {
           _mainRoleService = new();
        }

        [Fact]
        public async Task MainRoleShouldNotBe()
        {
            #region Kod Kısmı
            /*
                 MainRole mainRole = await _mainRoleService.GetById(request.id);
                 if (mainRole == null) throw new Exception("Role Bulunamadı!!");
             */
            #endregion
            _ = _mainRoleService.Setup(x =>
            x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new MainRole());
        }


        [Fact]
        public async Task UpdateMainRoleCommandShouldNotBeNull()
        {
            #region Kod Kısmı
            /*              
              await _rolesService.UpdateAsync(role);
             */
            #endregion

            var command = new UpdateMainRoleCommand(
                
                title: "Hesap kayıt planı silme Test",
                id: "UCAF.DeleteTest"
                );
            #region Kod Kısmıdaki kodu geçmek için
            /*
                AppRole role = await _rolesService.GetById(request.Id);
                if (role==null) throw new Exception("Role Bulunamdı");
             */
            _ = _mainRoleService.Setup(x =>
            x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new MainRole());
            #endregion
            var handler = new UpdateMainRoleHandler(_mainRoleService.Object);

            UpdateMainRoleResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();


        }

    }
}
