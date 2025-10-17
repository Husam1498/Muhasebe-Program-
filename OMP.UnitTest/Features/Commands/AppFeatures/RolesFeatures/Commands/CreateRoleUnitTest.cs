using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.RolesFeatures.Commands
{
    public class CreateRoleUnitTest
    {
        private readonly Mock<IRolesService> _roleService;

        public CreateRoleUnitTest()
        {
            _roleService = new();
        }

        [Fact]
        public async Task CreateRoleShouldBeNull()// handler içerisindeki app rolun nullsa 
        {

            AppRole role = await _roleService.Object.GetByCode("UcafCreate");

            role.ShouldBeNull();
        }

        [Fact]
        public async Task CreateRoleResponseShouldBeNotNull() 
        {
            var command = new CreateRoleCommand(
                Code: "TestCode",
                Name: "TestName");
            
            var handler= new CreateRoleCommandHandler(_roleService.Object);

            CreateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeNull();


        }

    }
}
