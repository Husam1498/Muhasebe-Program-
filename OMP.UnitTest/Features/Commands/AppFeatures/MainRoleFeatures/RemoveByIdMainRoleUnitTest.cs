using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.MainRoleFeatures
{
    public sealed class RemoveByIdMainRoleUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleServices;

        public RemoveByIdMainRoleUnitTest()
        {
            _mainRoleServices = new();
        }

        [Fact]
        public async Task CreateMainRoleResponseShouldNotBeNull()
        {
            var command = new RemoveMainRoleCommand(
                Id: "438cc12d-b618-440b-a493-0b2d2cee91ce"
                );

            var handler = new RemoveMainRoleHandler(_mainRoleServices.Object);

            RemoveMainRoleResponse response = await handler.Handle(command,default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı




        }


    }
}
