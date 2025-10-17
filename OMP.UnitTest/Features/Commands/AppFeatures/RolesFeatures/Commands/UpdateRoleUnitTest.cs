using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.UpdateRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.RolesFeatures.Commands
{
    public class UpdateRoleUnitTest
    {
        private readonly Mock<IRolesService> _roleService;

        public UpdateRoleUnitTest()
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
        public async Task AppRoleCodeShouldBeUniqe()
        {
           
            #region Kod Kısmı
            /*
                 if(role.Code!=request.Code)
             {
                 AppRole codeCheck = await _rolesService.GetByCode(request.Code);
                 if (codeCheck!=null) throw new Exception("Role Code Zaten Kayıtlı");
             
             }
             */
            #endregion

            AppRole checkRoleCode = await _roleService.Object.GetByCode("UCAF.Create");
            checkRoleCode.ShouldBeNull();

        }

        [Fact]
        public async Task UpdateRoleCommandShouldNotBeNull()
        {
            #region Kod Kısmı
            /*              
              await _rolesService.UpdateAsync(role);
             */
            #endregion

            var command= new UpdateRoleCommand(
                Id: "4308b8fd-dc22-45c0-a8b2-acbaaafb2c3dTest",
                Name: "Hesap kayıt planı silme Test",
                Code: "UCAF.DeleteTest"
                );
            #region Kod Kısmıdaki kodu geçmek için
            /*
                AppRole role = await _rolesService.GetById(request.Id);
                if (role==null) throw new Exception("Role Bulunamdı");
             */           
            _ = _roleService.Setup(x =>
            x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());
            #endregion
            var handler = new UpdateRoleCommandHandler(_roleService.Object);

            UpdateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();


        }

    }
}
