using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.MainRoleFeatures
{
    public sealed class CreateMainRoleUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleServices;

        public CreateMainRoleUnitTest()
        {
            _mainRoleServices = new();
        }

        [Fact]
        public async Task MainRoleShouldBeNull()
        {
            MainRole role = (await _mainRoleServices.Object.GetByTitleAndCompanyId(
                "Admin", 
                "438cc12d-b618-440b-a493-0b2d2cee91ce",
                default
                ));

            role.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleResponseShouldNotBeNull()
        {
            var command = new CreateMainRoleCommand(
                Title:"dsds",
              
                CompanyId: "438cc12d-b618-440b-a493-0b2d2cee91ce"
                );

            var handler = new CreateMainRoleCommandsHandler(_mainRoleServices.Object);

            CreatemainRoleCommandsResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı




        }


    }
}
