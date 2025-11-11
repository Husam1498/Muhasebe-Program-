using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.RemoveMainRoleAndUser;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.MaiinRoleAndUserFeatures
{
    public class RemoveByIdMainRoleAndUserUnitOfWorks
    {
        private readonly Mock<IMainRoleAndUserServices> _services;
        public RemoveByIdMainRoleAndUserUnitOfWorks()
        {
            _services = new();
        }

        [Fact]
        public async Task MainRoleAndUserRelationshipShouldNotBeNull()
        {
            _ = _services.Setup(x =>
            x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new MainRoleAndUserRelationship());
        }

        [Fact]
        public async Task RemoveByIdMainRoleAndUserResponseShouldNotBeNull()
        {
            var command = new RemoveByIdMainRoleAndUserCommand(
                id: "438cc12d-b618-440b-a493-0b2d2cee91ce"
                );
            var handler = new RemoveByIdMainRoleAndUserhandler(_services.Object);
           
            _ = _services.Setup(x =>
                    x.GetById(It.IsAny<string>()))
                    .ReturnsAsync(new MainRoleAndUserRelationship());

            RemoveByIdMainRoleAndUserResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı

        }
    }
}
