using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.RemoveById;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.MainRoleAndRoleFeatures
{
    public sealed class RemoveByIdMRARFCommandUnitTest
    {
        private readonly Mock<IMainRoleAndRoleRelationshipServices> _mainRoleServices;
        public RemoveByIdMRARFCommandUnitTest()
        {
            _mainRoleServices = new();
        }

        [Fact]
        public async Task MainRoleAndRoleRelationshipShouldNotBeNull()
        {
          
           
            _ = _mainRoleServices.Setup(x =>
            x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new MainRoleAndRoleRelationship());
        }

        [Fact]
        public async Task RemoveByIdMRARFCommandShouldNotBeNull()
        {
            var command = new RemoveByIdMRARFCommand(
                id: "438cc12d-b618-440b-a493-0b2d2cee91ce"
                );
            var handler = new RemoveByIdMRARFHandler(_mainRoleServices.Object);

            RemoveByIdMRARFResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı

        }

    }
}
